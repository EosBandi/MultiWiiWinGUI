using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace MultiWiiWinGUI
{
    public partial class frmAbout : Form
    {

        public string sVersionLabel
        {
            get { return this.l_version.Text; }
            set { this.l_version.Text = "Version " + value; }
        }

        public string sFcVersionLabel
        {
            get { return this.l_mwver.Text; }
            set { this.l_mwver.Text = value; }
        }


        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

            // Get the version of the current assembly.
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            label2.Text = String.Format("{0}", ver.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
