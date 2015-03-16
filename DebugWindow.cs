using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiWiiWinGUI
{
    public partial class DebugWindow : Form
    {

        public void AppendText(string Text)
        {
            textBox1.AppendText(Text);
        }

        public DebugWindow()
        {
            InitializeComponent();
        }

        private void bDebugClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
