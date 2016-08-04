namespace DirsToPackageTool
{
    partial class FrmLogMsg
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
            this.txtLogMsg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtLogMsg
            // 
            this.txtLogMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLogMsg.Location = new System.Drawing.Point(0, 0);
            this.txtLogMsg.Multiline = true;
            this.txtLogMsg.Name = "txtLogMsg";
            this.txtLogMsg.ReadOnly = true;
            this.txtLogMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogMsg.Size = new System.Drawing.Size(823, 349);
            this.txtLogMsg.TabIndex = 0;
            this.txtLogMsg.TextChanged += new System.EventHandler(this.txtLogMsg_TextChanged);
            this.txtLogMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogMsg_KeyPress);
            this.txtLogMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLogMsg_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 349);
            this.Controls.Add(this.txtLogMsg);
            this.Name = "FrmLogMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogMsg;
        private System.Windows.Forms.Timer timer1;
    }
}