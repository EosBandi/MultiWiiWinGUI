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
    public partial class splash_screen : Form
    {

        public string sVersionLabel
        {
            get { return this.l_version.Text; }
            set { this.l_version.Text = "Version "+value; }
        }

        public string sFcVersionLabel
        {
            get { return this.l_mwver.Text; }
            set { this.l_mwver.Text = value; }
        }

        public string sStatus
        {
            get { return this.lStatus.Text; }
            set { this.lStatus.Text = value; }
        }

        public splash_screen()
        {
            InitializeComponent();
            l_full_version.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lStatus.Text = "Initializing...";
        }

    }
}
