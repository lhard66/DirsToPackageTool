namespace DirsToPackageTool
{
    partial class FrmSet
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
            this.fbdTestPath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlZMS = new System.Windows.Forms.TabControl();
            this.tabPageZGW = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudFormal = new System.Windows.Forms.NumericUpDown();
            this.nudTest = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFormal = new System.Windows.Forms.GroupBox();
            this.txtBinFormalPath = new System.Windows.Forms.TextBox();
            this.btnBinFormalPath = new System.Windows.Forms.Button();
            this.txtFormalTarPath = new System.Windows.Forms.TextBox();
            this.btnFormalTarPath = new System.Windows.Forms.Button();
            this.txtFormalPath = new System.Windows.Forms.TextBox();
            this.btnFormalExpPath = new System.Windows.Forms.Button();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.txtBinTestPath = new System.Windows.Forms.TextBox();
            this.btnBinTestPath = new System.Windows.Forms.Button();
            this.txtTestTarPath = new System.Windows.Forms.TextBox();
            this.btnTestTarPath = new System.Windows.Forms.Button();
            this.txtTestPath = new System.Windows.Forms.TextBox();
            this.btnTestExpPath = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.CheckBox();
            this.lblMainLocation = new System.Windows.Forms.Label();
            this.tabControlZMS.SuspendLayout();
            this.tabPageZGW.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).BeginInit();
            this.groupBoxFormal.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlZMS
            // 
            this.tabControlZMS.Controls.Add(this.tabPageZGW);
            this.tabControlZMS.Controls.Add(this.tabPage2);
            this.tabControlZMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlZMS.Location = new System.Drawing.Point(0, 0);
            this.tabControlZMS.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlZMS.Name = "tabControlZMS";
            this.tabControlZMS.SelectedIndex = 0;
            this.tabControlZMS.Size = new System.Drawing.Size(374, 362);
            this.tabControlZMS.TabIndex = 2;
            // 
            // tabPageZGW
            // 
            this.tabPageZGW.Controls.Add(this.groupBox1);
            this.tabPageZGW.Controls.Add(this.groupBoxFormal);
            this.tabPageZGW.Controls.Add(this.groupBoxTest);
            this.tabPageZGW.Location = new System.Drawing.Point(4, 22);
            this.tabPageZGW.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageZGW.Name = "tabPageZGW";
            this.tabPageZGW.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageZGW.Size = new System.Drawing.Size(366, 336);
            this.tabPageZGW.TabIndex = 0;
            this.tabPageZGW.Text = "ZGW";
            this.tabPageZGW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudFormal);
            this.groupBox1.Controls.Add(this.nudTest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(366, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "其它";
            // 
            // nudFormal
            // 
            this.nudFormal.Location = new System.Drawing.Point(295, 20);
            this.nudFormal.Margin = new System.Windows.Forms.Padding(2);
            this.nudFormal.Name = "nudFormal";
            this.nudFormal.Size = new System.Drawing.Size(40, 21);
            this.nudFormal.TabIndex = 1;
            this.nudFormal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTest
            // 
            this.nudTest.Location = new System.Drawing.Point(121, 20);
            this.nudTest.Margin = new System.Windows.Forms.Padding(2);
            this.nudTest.Name = "nudTest";
            this.nudTest.Size = new System.Drawing.Size(46, 21);
            this.nudTest.TabIndex = 0;
            this.nudTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTest.Enter += new System.EventHandler(this.nudTest_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "将要打的正式包号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "将要打的测试包号：";
            // 
            // groupBoxFormal
            // 
            this.groupBoxFormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFormal.Controls.Add(this.txtBinFormalPath);
            this.groupBoxFormal.Controls.Add(this.btnBinFormalPath);
            this.groupBoxFormal.Controls.Add(this.txtFormalTarPath);
            this.groupBoxFormal.Controls.Add(this.btnFormalTarPath);
            this.groupBoxFormal.Controls.Add(this.txtFormalPath);
            this.groupBoxFormal.Controls.Add(this.btnFormalExpPath);
            this.groupBoxFormal.Location = new System.Drawing.Point(4, 137);
            this.groupBoxFormal.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFormal.Name = "groupBoxFormal";
            this.groupBoxFormal.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFormal.Size = new System.Drawing.Size(366, 131);
            this.groupBoxFormal.TabIndex = 8;
            this.groupBoxFormal.TabStop = false;
            this.groupBoxFormal.Text = "正式";
            // 
            // txtBinFormalPath
            // 
            this.txtBinFormalPath.Location = new System.Drawing.Point(0, 95);
            this.txtBinFormalPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtBinFormalPath.Name = "txtBinFormalPath";
            this.txtBinFormalPath.ReadOnly = true;
            this.txtBinFormalPath.Size = new System.Drawing.Size(274, 21);
            this.txtBinFormalPath.TabIndex = 9;
            // 
            // btnBinFormalPath
            // 
            this.btnBinFormalPath.Location = new System.Drawing.Point(278, 95);
            this.btnBinFormalPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinFormalPath.Name = "btnBinFormalPath";
            this.btnBinFormalPath.Size = new System.Drawing.Size(80, 20);
            this.btnBinFormalPath.TabIndex = 8;
            this.btnBinFormalPath.Text = "bin 路径";
            this.btnBinFormalPath.UseVisualStyleBackColor = true;
            this.btnBinFormalPath.Click += new System.EventHandler(this.btnBinFormalPath_Click);
            // 
            // txtFormalTarPath
            // 
            this.txtFormalTarPath.Location = new System.Drawing.Point(0, 60);
            this.txtFormalTarPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormalTarPath.Name = "txtFormalTarPath";
            this.txtFormalTarPath.ReadOnly = true;
            this.txtFormalTarPath.Size = new System.Drawing.Size(274, 21);
            this.txtFormalTarPath.TabIndex = 7;
            // 
            // btnFormalTarPath
            // 
            this.btnFormalTarPath.Location = new System.Drawing.Point(278, 60);
            this.btnFormalTarPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormalTarPath.Name = "btnFormalTarPath";
            this.btnFormalTarPath.Size = new System.Drawing.Size(80, 20);
            this.btnFormalTarPath.TabIndex = 6;
            this.btnFormalTarPath.Text = "目标路径";
            this.btnFormalTarPath.UseVisualStyleBackColor = true;
            this.btnFormalTarPath.Click += new System.EventHandler(this.btnFormalTarPath_Click);
            // 
            // txtFormalPath
            // 
            this.txtFormalPath.Location = new System.Drawing.Point(2, 24);
            this.txtFormalPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormalPath.Name = "txtFormalPath";
            this.txtFormalPath.ReadOnly = true;
            this.txtFormalPath.Size = new System.Drawing.Size(272, 21);
            this.txtFormalPath.TabIndex = 5;
            // 
            // btnFormalExpPath
            // 
            this.btnFormalExpPath.Location = new System.Drawing.Point(279, 24);
            this.btnFormalExpPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormalExpPath.Name = "btnFormalExpPath";
            this.btnFormalExpPath.Size = new System.Drawing.Size(80, 20);
            this.btnFormalExpPath.TabIndex = 4;
            this.btnFormalExpPath.Text = "导出路径";
            this.btnFormalExpPath.UseVisualStyleBackColor = true;
            this.btnFormalExpPath.Click += new System.EventHandler(this.btnFormalExpPath_Click);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTest.Controls.Add(this.txtBinTestPath);
            this.groupBoxTest.Controls.Add(this.btnBinTestPath);
            this.groupBoxTest.Controls.Add(this.txtTestTarPath);
            this.groupBoxTest.Controls.Add(this.btnTestTarPath);
            this.groupBoxTest.Controls.Add(this.txtTestPath);
            this.groupBoxTest.Controls.Add(this.btnTestExpPath);
            this.groupBoxTest.Location = new System.Drawing.Point(4, 6);
            this.groupBoxTest.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTest.Size = new System.Drawing.Size(366, 129);
            this.groupBoxTest.TabIndex = 4;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "测试";
            // 
            // txtBinTestPath
            // 
            this.txtBinTestPath.Location = new System.Drawing.Point(0, 94);
            this.txtBinTestPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtBinTestPath.Name = "txtBinTestPath";
            this.txtBinTestPath.ReadOnly = true;
            this.txtBinTestPath.Size = new System.Drawing.Size(274, 21);
            this.txtBinTestPath.TabIndex = 9;
            // 
            // btnBinTestPath
            // 
            this.btnBinTestPath.Location = new System.Drawing.Point(278, 94);
            this.btnBinTestPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinTestPath.Name = "btnBinTestPath";
            this.btnBinTestPath.Size = new System.Drawing.Size(80, 20);
            this.btnBinTestPath.TabIndex = 8;
            this.btnBinTestPath.Text = "bin 路径";
            this.btnBinTestPath.UseVisualStyleBackColor = true;
            this.btnBinTestPath.Click += new System.EventHandler(this.btnBinTestPath_Click);
            // 
            // txtTestTarPath
            // 
            this.txtTestTarPath.Location = new System.Drawing.Point(0, 58);
            this.txtTestTarPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtTestTarPath.Name = "txtTestTarPath";
            this.txtTestTarPath.ReadOnly = true;
            this.txtTestTarPath.Size = new System.Drawing.Size(274, 21);
            this.txtTestTarPath.TabIndex = 7;
            // 
            // btnTestTarPath
            // 
            this.btnTestTarPath.Location = new System.Drawing.Point(278, 58);
            this.btnTestTarPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestTarPath.Name = "btnTestTarPath";
            this.btnTestTarPath.Size = new System.Drawing.Size(80, 20);
            this.btnTestTarPath.TabIndex = 6;
            this.btnTestTarPath.Text = "目标路径";
            this.btnTestTarPath.UseVisualStyleBackColor = true;
            this.btnTestTarPath.Click += new System.EventHandler(this.btnTestTarPath_Click);
            // 
            // txtTestPath
            // 
            this.txtTestPath.Location = new System.Drawing.Point(2, 24);
            this.txtTestPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtTestPath.Name = "txtTestPath";
            this.txtTestPath.ReadOnly = true;
            this.txtTestPath.Size = new System.Drawing.Size(272, 21);
            this.txtTestPath.TabIndex = 5;
            // 
            // btnTestExpPath
            // 
            this.btnTestExpPath.Location = new System.Drawing.Point(279, 24);
            this.btnTestExpPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestExpPath.Name = "btnTestExpPath";
            this.btnTestExpPath.Size = new System.Drawing.Size(80, 20);
            this.btnTestExpPath.TabIndex = 4;
            this.btnTestExpPath.Text = "导出路径";
            this.btnTestExpPath.UseVisualStyleBackColor = true;
            this.btnTestExpPath.Click += new System.EventHandler(this.btnTestExpPath_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(366, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ZMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(287, 364);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 30);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.AutoSize = true;
            this.cbLocation.Location = new System.Drawing.Point(12, 372);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(120, 16);
            this.cbLocation.TabIndex = 10;
            this.cbLocation.Text = "保存主窗体位置：";
            this.cbLocation.UseVisualStyleBackColor = true;
            // 
            // lblMainLocation
            // 
            this.lblMainLocation.AutoSize = true;
            this.lblMainLocation.Location = new System.Drawing.Point(132, 373);
            this.lblMainLocation.Name = "lblMainLocation";
            this.lblMainLocation.Size = new System.Drawing.Size(17, 12);
            this.lblMainLocation.TabIndex = 11;
            this.lblMainLocation.Text = "无";
            // 
            // FrmSet
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 404);
            this.Controls.Add(this.lblMainLocation);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.tabControlZMS);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.TopMost = true;
            this.tabControlZMS.ResumeLayout(false);
            this.tabPageZGW.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).EndInit();
            this.groupBoxFormal.ResumeLayout(false);
            this.groupBoxFormal.PerformLayout();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdTestPath;
        private System.Windows.Forms.TabControl tabControlZMS;
        private System.Windows.Forms.TabPage tabPageZGW;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.TextBox txtTestTarPath;
        private System.Windows.Forms.Button btnTestTarPath;
        private System.Windows.Forms.TextBox txtTestPath;
        private System.Windows.Forms.Button btnTestExpPath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxFormal;
        private System.Windows.Forms.TextBox txtFormalTarPath;
        private System.Windows.Forms.Button btnFormalTarPath;
        private System.Windows.Forms.TextBox txtFormalPath;
        private System.Windows.Forms.Button btnFormalExpPath;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTest;
        private System.Windows.Forms.NumericUpDown nudFormal;
        private System.Windows.Forms.TextBox txtBinTestPath;
        private System.Windows.Forms.Button btnBinTestPath;
        private System.Windows.Forms.TextBox txtBinFormalPath;
        private System.Windows.Forms.Button btnBinFormalPath;
        private System.Windows.Forms.CheckBox cbLocation;
        private System.Windows.Forms.Label lblMainLocation;
    }
}