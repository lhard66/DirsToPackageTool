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
    public partial class FrmLogMsg : Form
    {
        public FrmLogMsg()
        {
            InitializeComponent();
            //初始化窗体时，注册事件
            //ObsolotorLogMsg.logMsgEvent += ObsolotorLogMsg_msgHandler;
            //使用lumia替代传统添加事件方式。lumia即是匿名方法的简写。
            ObsolotorLogMsg.logMsgEvent += s => txtLogMsg.Text = s;
            timer1.Start();
        }

        //void ObsolotorLogMsg_msgHandler(string strMsg)
        //{
        //    txtLogMsg.Text = strMsg;
        //}
        
        private int timeNum = 15;
        private bool isFinish = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isFinish)
            {
                if (timeNum == 0)
                {
                    this.Close();
                }
                else
                {
                    this.Text = timeNum-- + "秒后自动关闭窗体";
                }
                return;
            }
            
            if (txtLogMsg.Text.Contains("打包完毕❤"))
            {
                isFinish = true;
            }            
            
        }

        private void txtLogMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
            timer1.Stop();
            this.Text = "日志";
        }

        private void txtLogMsg_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            this.Text = "日志";
        }

        private void txtLogMsg_TextChanged(object sender, EventArgs e)
        {
            txtLogMsg.Focus();
            txtLogMsg.Select(txtLogMsg.Text.Length, 0);
            txtLogMsg.ScrollToCaret();
        }

       
    }
}
