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
    public partial class ToolHelp : Form
    {
        public string num2;
        public string num3;
        public string num4;
        public ToolHelp()
        {
            InitializeComponent();
            
        }

        private void ToolHelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
