using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirsToPackageTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (!XmlOperation.GetXmlIntoSetEntity())
            {
                MessageBox.Show("注意，配置文件有问题，请联系开发刘天青。");
                System.Environment.Exit(0);
            }
            refreshData();
            //注册委托事件
            //ObsolotorLogMsg.msgHandler += ObsolotorLogMsg_msgHandler;

        }

        //void ObsolotorLogMsg_msgHandler(string strMsg)
        //{
        //    strMsg = txtMsg.Text;
        //}        

        private void btnTestPackage_Click(object sender, EventArgs e)
        {
            if (!CheckVaildAndInit())
            {
                return;
            }
            //若移动文件出现异常则捕获
            bool IsCopySuccess = false;
            try
            {
                IsCopySuccess = CopyPackageFilesToDesk(ToolEnum.WebType.test);
            }
            catch (Exception ex)
            {
                txtMsg.AppendText("异常！内容为：" + ex.Message);
                return;
            }

            //将需要打包的文件，复制到桌面。若失败则显示提示信息
            if (!IsCopySuccess)
            {
                txtMsg.AppendText("打包失败，请联系开发刘天青！\r\n可能原因：索引不能为-1或都是类文件");
                return;
            }
            if (!ProcessPackage(SetEntity.WebName, ToolEnum.WebType.test))
            {
                txtMsg.AppendText("打包失败，请联系开发刘天青！\r\n");
                return;
            }

            InitCheckBoxes();
            txtMsg.AppendText("打包完毕❤");
        }

        private bool CopyPackageFilesToDesk(ToolEnum.WebType webtype)
        {
            txtMsg.AppendText("开始准备抽取文件...\r\n");
            string strContent = txtClipper.Text.Replace('/', '\\');
            string[] strPaths = strContent.Split('\n');
            //要复制文件的地址
            //项目所在地址
            string strSourceDir = null;
            string strTargetDir = null;
            if (webtype == ToolEnum.WebType.test)
            {
                strSourceDir = SetEntity.TestBinPath.Substring(0, SetEntity.TestBinPath.IndexOf("Horizon"));
                //获得桌面所在路径
                strTargetDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\trunk\zgwtrunk\";
            }
            else if (webtype == ToolEnum.WebType.formal)
            {
                strSourceDir = SetEntity.FormalBinPath.Substring(0, SetEntity.FormalBinPath.IndexOf("Horizon"));
                strTargetDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\trunk\trunkV1.0\";
            }
            else
            {
                return false;
            }

            //截取有用的字符串路径,并复制文件到指定的目录下        
            txtMsg.AppendText("抽取文件准备工作完成，开始逐个创建项目层级文件夹并移动文件...\r\n");
            int fileSum = 0;
            foreach (var item in strPaths)
            {
                if (item == "")
                {
                    continue;
                }
                //得到文件扩展名，判断是否是类文件
                string strExt = Path.GetExtension(item);
                if (strExt == ".cs"||strExt=="")
                {
                    continue;
                }
                int clipperIndex = item.IndexOf("Horizon");
                if (clipperIndex < 0)
                {
                    return false;
                }
                //获得有效路径
                string strVail = item.Substring(clipperIndex);
                //获得源文件所在路径
                string strSourcePath = strSourceDir + strVail;

                //获得目标所在文件夹路径
                string strTarGetPath = strTargetDir + strVail;
                try
                {
                    //创建文件夹
                    Directory.CreateDirectory(Path.GetDirectoryName(strTarGetPath));
                    //复制移动文件,遇到同名文件则覆盖它                    
                    File.Copy(strSourcePath, strTarGetPath, true);
                    fileSum++;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            txtMsg.AppendText("抽取文件工作完成，共【" + fileSum + "】个文件！♛\r\n");
            return true;
        }
        private bool CheckVaildAndInit()
        {

            txtMsg.Text = "";
            if (txtCommitMsg.Text == "")
            {
                txtMsg.AppendText("日志信息不能为空！\r\n");
                return false;
            }
            if (tsmLogFrm.Checked)
            {
                FrmLogMsg frmLog = new FrmLogMsg();
                frmLog.Show();
            }
            return true;
        }
        private void InitCheckBoxes()
        {
            InitCheckBoxBin(cbWe);
            InitCheckBoxBin(cbEn);
            InitCheckBoxBin(cbDo);
            InitCheckBoxBin(cbIn);
        }
        //初始化checkbox
        private void InitCheckBoxBin(CheckBox cb)
        {
            if (cb.Checked)
            {
                cb.ForeColor = Color.Red;
                cb.Checked = false;
            }
            else
            {
                cb.ForeColor = Color.Black;
            }
        }

        private bool ProcessPackage(ToolEnum.WebName webName, ToolEnum.WebType webType)
        {
            string strExpPath = "", strTarPath = "", strBinPath = "", strPackageFlag = "";
            int packageNum = 0;//表示第几个包

            switch (GetWhatPackage(webName, webType))
            {
                case 1://zgw测试
                    strExpPath = SetEntity.TestExpPath;
                    strTarPath = SetEntity.TestTarPath;
                    strBinPath = SetEntity.TestBinPath;
                    packageNum = SetEntity.TestNum;
                    strPackageFlag = @"\t_";
                    break;
                case 2://zgw正式
                    strExpPath = SetEntity.FormalExpPath;
                    strTarPath = SetEntity.FormalTarPath;
                    strBinPath = SetEntity.FormalBinPath;
                    packageNum = SetEntity.FormalNum;
                    strPackageFlag = @"\p_";
                    break;
                case 3://zms测试
                    return false;
                //break;
                case 4://zms正式
                    return false;
                //break;
                case 0://错误
                    return false;
            }


            //需要判定一下选择的路径是否存在
            if (strExpPath == "" || strTarPath == "" || strBinPath == "")
            {
                txtMsg.AppendText("导出路径或目标路径不能为空！请点击设置，设置路径。\r\n");
                return false;
            }
            //判断导出路径下是否有文件或文件夹
            if (System.IO.Directory.GetDirectories(strExpPath).Length < 1 && !IsMoveBinFiles())
            {
                txtMsg.AppendText("未导出任何文件，移动失败！\r\n");
                return false;
            }
            //构造打包文件夹路径并创建            
            StringBuilder sbPath = new StringBuilder();
            sbPath.Append(strTarPath);
            sbPath.Append(strPackageFlag);
            sbPath.Append(DateTime.Now.ToString("yyyyMMdd"));
            sbPath.Append("_");
            sbPath.Append(packageNum);
            string strPath = sbPath.ToString();

            //创建打包文件夹
            if (Common.DirectoryIsExists(strPath))
            {
                txtMsg.AppendText("目录已存在，打包失败！\r\n");
                return false;
            }

            if (!MoveBinAndCreatePackage(strPath, strBinPath))
            {
                txtMsg.AppendText("bin文件不存在，请重新编译！\r\n");
                return false;
            }
            txtMsg.AppendText("打包文件夹已创建并完成bin相关工作，正在移动SVN导出文件...\r\n");
            Common.MoveFiles(strExpPath, strPath, true, true);
            //多线程
            //Thread threadMoveFile = new Thread(() =>
            //{

            //});
            //threadMoveFile.IsBackground = true;
            //threadMoveFile.Join();
            //threadMoveFile.Start();

            txtMsg.AppendText("打包内容移动完成，正在添加至SVN...\r\n");
            //System.Diagnostics.Process.Start("Explorer.exe", @"/select," + strPath);
            //svn添加文件夹并提交             
            string strSvnMsg = "";//定义svn日志信息变量
            txtMsg.AppendText(Common.ExecuteDos("svn add " + strPath, 30));
            txtMsg.AppendText("添加至SVN完成，休眠2秒后提交至SVN...\r\n");
            Thread.Sleep(2000);
            StringBuilder sb = new StringBuilder();
            sb.Append("svn commit ");
            if (!txtCommitMsg.Text.Equals(""))
            {
                sb.Append("-m " + lblJobNum.Text + txtCommitMsg.Text + " ");
            }
            sb.Append(strPath);
            //多线程
            Thread threadCommit = new Thread(() =>
            {
                strSvnMsg = Common.ExecuteDos(sb.ToString(), 100);
            });
            threadCommit.IsBackground = true;
            threadCommit.Start();
            threadCommit.Join();
            txtMsg.AppendText(strSvnMsg);
            txtMsg.AppendText("提交至SVN完成。\r\n");
            switch (GetWhatPackage(webName, webType))
            {
                case 1://zgw测试
                    btnTestPackage.Text = "测试打包-->" + packageNum++;
                    SetEntity.TestNum = packageNum;
                    break;
                case 2://zgw正式
                    btnFormalPackage.Text = "正式打包-->" + packageNum++;
                    SetEntity.FormalNum = packageNum;
                    break;
                case 3://zms测试
                    break;
                case 4://zms正式
                    break;
            }
            return true;
        }
        private int GetWhatPackage(ToolEnum.WebName webName, ToolEnum.WebType webType)
        {
            if (webName == ToolEnum.WebName.zgw)
            {
                if (webType == ToolEnum.WebType.test)
                {
                    return 1;
                }
                else if (webType == ToolEnum.WebType.formal)
                {
                    return 2;
                }
            }
            else if (webName == ToolEnum.WebName.zms)
            {
                if (webType == ToolEnum.WebType.test)
                {
                    return 3;
                }
                else if (webType == ToolEnum.WebType.formal)
                {
                    return 4;
                }
            }
            return 0;
        }
        private bool IsMoveBinFiles()
        {
            return cbDo.Checked || cbEn.Checked || cbIn.Checked || cbWe.Checked;
        }
        //移动的逻辑判断
        private bool MoveBinAndCreatePackage(string strPath, string strOriginbinPath)
        {
            //在打包文件夹中创建bin文件夹
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (cbWe.Checked)
            {
                dict.Add("cbWe", "Horizon.Web.dll");
            }
            if (cbDo.Checked)
            {
                dict.Add("cbDo", "Horizon.Domain.dll");
            }
            if (cbEn.Checked)
            {
                dict.Add("cbEn", "Horizon.Entities.dll");
            }
            if (cbIn.Checked)
            {
                dict.Add("cbIn", "Horizon.Infrastructure.dll");
            }
            //检查bin文件是否存在
            foreach (var itemDic in dict)
            {
                if (!Common.FileExists(strOriginbinPath, itemDic.Value))
                {
                    return false;
                }
            }
            if (dict.Count > 0)
            {
                string strBinPath = strPath + @"\bin";
                //创建bin文件夹
                Common.CreateDirectory(strBinPath);
                foreach (var item in dict)
                {
                    File.Copy(strOriginbinPath + "\\" + item.Value, strBinPath + "\\" + item.Value);
                }
            }
            else
            {
                //创建打包文件夹
                Common.CreateDirectory(strPath);
            }
            return true;
        }

        private void refreshData()
        {
            btnTestPackage.Text = "测试打包-->" + SetEntity.TestNum;
            btnFormalPackage.Text = "正式打包-->" + SetEntity.FormalNum;

            this.Location = SetEntity.Point;
        }

        private void tsmOption_Click(object sender, EventArgs e)
        {
            FrmSet frmSet = new FrmSet();
            DialogResult result = frmSet.ShowDialog();
            if (result == DialogResult.OK)
            {
                refreshData();
            }
        }

        private void tsmTop_Click(object sender, EventArgs e)
        {
            if (tsmTop.Checked)
            {
                this.TopMost = false;
                tsmTop.Checked = false;
            }
            else
            {
                this.TopMost = true;
                tsmTop.Checked = true;
            }
        }

        private void notifyIconMain_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            txtMsg.ScrollToCaret();
            ObsolotorLogMsg.CallMsgHandler(txtMsg.Text);
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            txtCommitMsg.Focus();
            txtCommitMsg.SelectAll();
        }


        private void zGWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEntity.WebName = ToolEnum.WebName.zgw;
            this.Text = "ZGW打包";
            zGWToolStripMenuItem.Checked = true;
            zMSToolStripMenuItem.Checked = false;
        }

        private void zMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEntity.WebName = ToolEnum.WebName.zms;
            this.Text = "ZMS打包";
            zGWToolStripMenuItem.Checked = false;
            zMSToolStripMenuItem.Checked = true;
        }

        private void btnFormalPackage_Click(object sender, EventArgs e)
        {
            if (!CheckVaildAndInit())
            {
                return;
            }
            //若移动文件出现异常则捕获
            bool IsCopySuccess = false;
            try
            {
                IsCopySuccess = CopyPackageFilesToDesk(ToolEnum.WebType.formal);
            }
            catch (Exception ex)
            {
                txtMsg.AppendText(ex.Message);
                return;
            }

            //将需要打包的文件，复制到桌面。若失败则显示提示信息
            if (!IsCopySuccess)
            {
                txtMsg.AppendText("打包失败，请联系开发刘天青！\r\n可能原因：索引不能为-1或都是类文件");
                return;
            }
            if (!ProcessPackage(SetEntity.WebName, ToolEnum.WebType.formal))
            {
                txtMsg.AppendText("打包失败，请联系开发刘天青！\r\n");
                return;
            }
            InitCheckBoxes();
            txtMsg.AppendText("打包完毕❤");
        }



        private void txtCommitMsg_Click(object sender, EventArgs e)
        {
            txtCommitMsg.SelectAll();
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            ToolHelp frmHelp = new ToolHelp();
            frmHelp.TopMost = true;
            frmHelp.ShowDialog();
        }

        private void tsmZGWTest_Click(object sender, EventArgs e)
        {
            if (!tsmZGWTest.Checked)
            {
                tsmZGWTest.Checked = true;
                tsmZGWFormal.Checked = false;
                txtClipper.BackColor = SystemColors.Window;
            }
        }

        private void tsmZGWFormal_Click(object sender, EventArgs e)
        {
            if (!tsmZGWFormal.Checked)
            {
                tsmZGWFormal.Checked = true;
                tsmZGWTest.Checked = false;
                txtClipper.BackColor = Color.LightYellow;
            }

        }

        private void tsmLogFrm_Click(object sender, EventArgs e)
        {
            if (tsmLogFrm.Checked)
            {
                tsmLogFrm.Checked = false;
            }
            else
            {
                tsmLogFrm.Checked = true;
            }
        }

        private void txtMsg_DoubleClick(object sender, EventArgs e)
        {
            FrmLogMsg frmLog = new FrmLogMsg();
            frmLog.Show();
            ObsolotorLogMsg.CallMsgHandler(txtMsg.Text);
        }

        private void Main_LocationChanged(object sender, EventArgs e)
        {
            Point point = this.Location;
            SetEntity.Point = point;

        }

        private void txtClipper_Click(object sender, EventArgs e)
        {
            if (txtClipper.Text.Trim() == "")
            {
                txtClipper.SelectionStart = 0;
                return;
            }
            //得到行号
            int lineNum = txtClipper.GetLineFromCharIndex(txtClipper.SelectionStart);
            //该行第一个字符的索引
            int firstCharNum = txtClipper.GetFirstCharIndexFromLine(lineNum);
            //选择此行文本
            if (txtClipper.Text.Trim() == "") return;
            txtClipper.Select(firstCharNum, txtClipper.Lines[lineNum].Length);
            string strSvnUrl = null;
            if (tsmZGWTest.Checked)
            {
                strSvnUrl = txtClipper.SelectedText.Trim();
            }
            else
            {
                string strFormalClipper = txtClipper.SelectedText.Trim();
                int clipperIndex = strFormalClipper.IndexOf("Horizon");
                if (clipperIndex < 1) return;
                strFormalClipper = strFormalClipper.Substring(clipperIndex);
                strSvnUrl = "/trunk/zgwtrunk/" + strFormalClipper;
            }
            //剪切选定文本            
            Clipboard.SetText("https://117.158.149.118/svn/ZgwVersionSVN" + strSvnUrl);
            //删除选择行
            txtClipper.SelectionColor = Color.Red;
        }

        private void txtCommitMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'v')
            {
                txtClipper.Text = "";
                txtClipper.Text = Clipboard.GetText();

            }

        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
            }
            else
            {
                this.ShowInTaskbar = false;
            }
        }

        private void tsmClipperClear_Click(object sender, EventArgs e)
        {
            txtClipper.Text = "";
        }








    }
}
