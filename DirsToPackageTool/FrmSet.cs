using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirsToPackageTool
{
    public partial class FrmSet : Form
    {
        public FrmSet()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            txtTestPath.Text = SetEntity.TestExpPath;
            txtTestTarPath.Text = SetEntity.TestTarPath;
            txtBinTestPath.Text = SetEntity.TestBinPath;
            nudTest.Value = SetEntity.TestNum;

            txtFormalPath.Text = SetEntity.FormalExpPath;
            txtFormalTarPath.Text = SetEntity.FormalTarPath;
            txtBinFormalPath.Text = SetEntity.FormalBinPath;
            nudFormal.Value = SetEntity.FormalNum;

            //Main窗体位置信息
            lblMainLocation.Text = SetEntity.Point.X + "," + SetEntity.Point.Y;
            
        }

        
        private void btnTestTarPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);
        }

        private void btnTestExpPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);           
        }
        private void btnBinTestPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);           
        }
        private void ShowDialogBox(object sender)
        {
            DialogResult result = fbdTestPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    switch (control.Name)
                    {
                        case "btnTestExpPath":
                            txtTestPath.Text = fbdTestPath.SelectedPath;
                            break;
                        case "btnTestTarPath":
                            txtTestTarPath.Text = fbdTestPath.SelectedPath;
                            break;
                        case "btnBinTestPath":
                            txtBinTestPath.Text = fbdTestPath.SelectedPath;
                            break;

                        case "btnFormalExpPath":
                            txtFormalPath.Text = fbdTestPath.SelectedPath;
                            break;
                        case "btnFormalTarPath":
                            txtFormalTarPath.Text = fbdTestPath.SelectedPath;
                            break;
                        case "btnBinFormalPath":
                            txtBinFormalPath.Text = fbdTestPath.SelectedPath;
                            break;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //检查源路径和目的路径是否相同
            if (isSamePath(txtTestPath.Text, txtTestTarPath.Text)||txtTestPath.Text==""||txtTestTarPath.Text=="")
            {
                MessageBox.Show("导出路径和目标路径不能相同或为空！");
                return;
            }            
            foreach (var item in tabPageZGW.Controls)
            {
                GroupBox gbContent = item as GroupBox;
                if (gbContent != null)
                {
                    foreach (var control in gbContent.Controls)
                    {
                        TextBox txtContent = control as TextBox;                        
                        if (txtContent != null)
                        {
                            switch (txtContent.Name)
                            {
                                case "txtTestPath":
                                    SetEntity.TestExpPath = txtContent.Text;
                                    break;
                                case "txtTestTarPath":
                                    SetEntity.TestTarPath = txtContent.Text;
                                    break;
                                case "txtBinTestPath":
                                    SetEntity.TestBinPath = txtContent.Text;
                                    break;
                                case "txtFormalPath":
                                    SetEntity.FormalExpPath = txtContent.Text;
                                    break;
                                case "txtFormalTarPath":
                                    SetEntity.FormalTarPath = txtContent.Text;
                                    break;
                                case "txtBinFormalPath":
                                    SetEntity.FormalBinPath = txtContent.Text;
                                    break;
                            }
                            continue;
                        }
                        NumericUpDown nudContent = control as NumericUpDown;
                        if (nudContent != null)
                        {
                            switch (nudContent.Name)
                            {
                                case "nudTest":
                                    SetEntity.TestNum = (int)nudContent.Value;
                                    break;
                                case "nudFormal":
                                    SetEntity.FormalNum = (int)nudContent.Value;
                                    break;
                            }
                            continue;
                        }                        
                    }
                }
                
            }
            //将SetEnity写入xml中
            XmlOperation.SetXmlIntoSetEntity(cbLocation.Checked);

            this.DialogResult = DialogResult.OK;
            this.Close();            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathOne"></param>
        /// <param name="pathTwo"></param>
        /// <returns></returns>
        private bool isSamePath(string pathOne, string pathTwo)
        {
            if (pathOne == pathTwo)
            {
                return true;
            }
            return false;
        }

        private void btnFormalExpPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);       
        }

        private void btnFormalTarPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);       
        }

        private void btnBinFormalPath_Click(object sender, EventArgs e)
        {
            ShowDialogBox(sender);       
        }

        private void nudTest_Enter(object sender, EventArgs e)
        {
            
        }

        

        
          
        
    }
}
