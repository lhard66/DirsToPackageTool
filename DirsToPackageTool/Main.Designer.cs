namespace DirsToPackageTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTop = new System.Windows.Forms.ToolStripMenuItem();
            this.打包项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zGWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOption = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZGWTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZGWFormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClipperClear = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClipper = new System.Windows.Forms.RichTextBox();
            this.lblJobNum = new System.Windows.Forms.Label();
            this.cbIn = new System.Windows.Forms.CheckBox();
            this.cbDo = new System.Windows.Forms.CheckBox();
            this.cbEn = new System.Windows.Forms.CheckBox();
            this.cbWe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommitMsg = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnFormalPackage = new System.Windows.Forms.Button();
            this.btnTestPackage = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSet,
            this.编辑ToolStripMenuItem,
            this.tsmHelp,
            this.tsmClipperClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(346, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSet
            // 
            this.tsmSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTop,
            this.打包项目ToolStripMenuItem,
            this.tsmLogFrm,
            this.tsmOption});
            this.tsmSet.Name = "tsmSet";
            this.tsmSet.Size = new System.Drawing.Size(44, 21);
            this.tsmSet.Text = "设置";
            // 
            // tsmTop
            // 
            this.tsmTop.Checked = true;
            this.tsmTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmTop.Name = "tsmTop";
            this.tsmTop.Size = new System.Drawing.Size(124, 22);
            this.tsmTop.Text = "置顶";
            this.tsmTop.Click += new System.EventHandler(this.tsmTop_Click);
            // 
            // 打包项目ToolStripMenuItem
            // 
            this.打包项目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zGWToolStripMenuItem,
            this.zMSToolStripMenuItem});
            this.打包项目ToolStripMenuItem.Name = "打包项目ToolStripMenuItem";
            this.打包项目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打包项目ToolStripMenuItem.Text = "打包项目";
            // 
            // zGWToolStripMenuItem
            // 
            this.zGWToolStripMenuItem.Checked = true;
            this.zGWToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zGWToolStripMenuItem.Name = "zGWToolStripMenuItem";
            this.zGWToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.zGWToolStripMenuItem.Text = "ZGW";
            this.zGWToolStripMenuItem.Click += new System.EventHandler(this.zGWToolStripMenuItem_Click);
            // 
            // zMSToolStripMenuItem
            // 
            this.zMSToolStripMenuItem.Name = "zMSToolStripMenuItem";
            this.zMSToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.zMSToolStripMenuItem.Text = "ZMS";
            this.zMSToolStripMenuItem.Click += new System.EventHandler(this.zMSToolStripMenuItem_Click);
            // 
            // tsmLogFrm
            // 
            this.tsmLogFrm.Checked = true;
            this.tsmLogFrm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmLogFrm.Name = "tsmLogFrm";
            this.tsmLogFrm.Size = new System.Drawing.Size(124, 22);
            this.tsmLogFrm.Text = "日志弹窗";
            this.tsmLogFrm.Click += new System.EventHandler(this.tsmLogFrm_Click);
            // 
            // tsmOption
            // 
            this.tsmOption.Name = "tsmOption";
            this.tsmOption.Size = new System.Drawing.Size(124, 22);
            this.tsmOption.Text = "选项";
            this.tsmOption.Click += new System.EventHandler(this.tsmOption_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmZGWTest,
            this.tsmZGWFormal});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // tsmZGWTest
            // 
            this.tsmZGWTest.Checked = true;
            this.tsmZGWTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmZGWTest.Name = "tsmZGWTest";
            this.tsmZGWTest.Size = new System.Drawing.Size(152, 22);
            this.tsmZGWTest.Text = "ZGW测试环境";
            this.tsmZGWTest.Click += new System.EventHandler(this.tsmZGWTest_Click);
            // 
            // tsmZGWFormal
            // 
            this.tsmZGWFormal.BackColor = System.Drawing.SystemColors.Window;
            this.tsmZGWFormal.Name = "tsmZGWFormal";
            this.tsmZGWFormal.Size = new System.Drawing.Size(152, 22);
            this.tsmZGWFormal.Text = "ZGW正式环境";
            this.tsmZGWFormal.Click += new System.EventHandler(this.tsmZGWFormal_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmHelp.Text = "帮助";
            this.tsmHelp.Click += new System.EventHandler(this.tsmHelp_Click);
            // 
            // tsmClipperClear
            // 
            this.tsmClipperClear.Name = "tsmClipperClear";
            this.tsmClipperClear.Size = new System.Drawing.Size(44, 21);
            this.tsmClipperClear.Text = "清空";
            this.tsmClipperClear.Click += new System.EventHandler(this.tsmClipperClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtClipper);
            this.panel1.Controls.Add(this.lblJobNum);
            this.panel1.Controls.Add(this.cbIn);
            this.panel1.Controls.Add(this.cbDo);
            this.panel1.Controls.Add(this.cbEn);
            this.panel1.Controls.Add(this.cbWe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCommitMsg);
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.btnFormalPackage);
            this.panel1.Controls.Add(this.btnTestPackage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 361);
            this.panel1.TabIndex = 3;
            // 
            // txtClipper
            // 
            this.txtClipper.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClipper.Location = new System.Drawing.Point(9, 204);
            this.txtClipper.Name = "txtClipper";
            this.txtClipper.Size = new System.Drawing.Size(325, 154);
            this.txtClipper.TabIndex = 11;
            this.txtClipper.Text = "";
            this.txtClipper.WordWrap = false;
            this.txtClipper.Click += new System.EventHandler(this.txtClipper_Click);
            // 
            // lblJobNum
            // 
            this.lblJobNum.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJobNum.Location = new System.Drawing.Point(88, 70);
            this.lblJobNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobNum.Name = "lblJobNum";
            this.lblJobNum.Size = new System.Drawing.Size(14, 18);
            this.lblJobNum.TabIndex = 1;
            this.lblJobNum.Text = "5";
            // 
            // cbIn
            // 
            this.cbIn.AutoSize = true;
            this.cbIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIn.Location = new System.Drawing.Point(296, 73);
            this.cbIn.Margin = new System.Windows.Forms.Padding(2);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(36, 16);
            this.cbIn.TabIndex = 6;
            this.cbIn.Text = "In";
            this.cbIn.UseVisualStyleBackColor = true;
            // 
            // cbDo
            // 
            this.cbDo.AutoSize = true;
            this.cbDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDo.Location = new System.Drawing.Point(215, 73);
            this.cbDo.Margin = new System.Windows.Forms.Padding(2);
            this.cbDo.Name = "cbDo";
            this.cbDo.Size = new System.Drawing.Size(36, 16);
            this.cbDo.TabIndex = 4;
            this.cbDo.Text = "Do";
            this.cbDo.UseVisualStyleBackColor = true;
            // 
            // cbEn
            // 
            this.cbEn.AutoSize = true;
            this.cbEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEn.Location = new System.Drawing.Point(256, 73);
            this.cbEn.Margin = new System.Windows.Forms.Padding(2);
            this.cbEn.Name = "cbEn";
            this.cbEn.Size = new System.Drawing.Size(36, 16);
            this.cbEn.TabIndex = 5;
            this.cbEn.Text = "En";
            this.cbEn.UseVisualStyleBackColor = true;
            // 
            // cbWe
            // 
            this.cbWe.AutoSize = true;
            this.cbWe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWe.Location = new System.Drawing.Point(178, 72);
            this.cbWe.Margin = new System.Windows.Forms.Padding(2);
            this.cbWe.Name = "cbWe";
            this.cbWe.Size = new System.Drawing.Size(36, 16);
            this.cbWe.TabIndex = 3;
            this.cbWe.Text = "We";
            this.cbWe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "SVN提交日志:";
            // 
            // txtCommitMsg
            // 
            this.txtCommitMsg.Location = new System.Drawing.Point(104, 68);
            this.txtCommitMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommitMsg.Name = "txtCommitMsg";
            this.txtCommitMsg.Size = new System.Drawing.Size(60, 21);
            this.txtCommitMsg.TabIndex = 0;
            this.txtCommitMsg.Click += new System.EventHandler(this.txtCommitMsg_Click);
            this.txtCommitMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommitMsg_KeyPress);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(9, 93);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(325, 105);
            this.txtMsg.TabIndex = 6;
            this.txtMsg.WordWrap = false;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            this.txtMsg.DoubleClick += new System.EventHandler(this.txtMsg_DoubleClick);
            // 
            // btnFormalPackage
            // 
            this.btnFormalPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormalPackage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFormalPackage.Location = new System.Drawing.Point(178, 7);
            this.btnFormalPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormalPackage.Name = "btnFormalPackage";
            this.btnFormalPackage.Size = new System.Drawing.Size(154, 55);
            this.btnFormalPackage.TabIndex = 1;
            this.btnFormalPackage.Text = "正式打包";
            this.btnFormalPackage.UseVisualStyleBackColor = true;
            this.btnFormalPackage.Click += new System.EventHandler(this.btnFormalPackage_Click);
            // 
            // btnTestPackage
            // 
            this.btnTestPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestPackage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTestPackage.Location = new System.Drawing.Point(9, 7);
            this.btnTestPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestPackage.Name = "btnTestPackage";
            this.btnTestPackage.Size = new System.Drawing.Size(154, 55);
            this.btnTestPackage.TabIndex = 2;
            this.btnTestPackage.Text = "测试打包";
            this.btnTestPackage.UseVisualStyleBackColor = true;
            this.btnTestPackage.Click += new System.EventHandler(this.btnTestPackage_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "notifyIcon";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseClick);
            // 
            // Main
            // 
            this.AcceptButton = this.btnTestPackage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "11";
            this.Text = "ZGW打包";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.LocationChanged += new System.EventHandler(this.Main_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSet;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFormalPackage;
        private System.Windows.Forms.Button btnTestPackage;
        private System.Windows.Forms.ToolStripMenuItem tsmTop;
        private System.Windows.Forms.ToolStripMenuItem tsmOption;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtCommitMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIn;
        private System.Windows.Forms.CheckBox cbDo;
        private System.Windows.Forms.CheckBox cbEn;
        private System.Windows.Forms.CheckBox cbWe;
        private System.Windows.Forms.ToolStripMenuItem 打包项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zGWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zMSToolStripMenuItem;
        private System.Windows.Forms.Label lblJobNum;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmZGWTest;
        private System.Windows.Forms.ToolStripMenuItem tsmZGWFormal;
        private System.Windows.Forms.ToolStripMenuItem tsmLogFrm;
        private System.Windows.Forms.RichTextBox txtClipper;
        private System.Windows.Forms.ToolStripMenuItem tsmClipperClear;
    }
}