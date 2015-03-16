using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Data;
using System.IO;
using System.IO.Ports;

namespace MultiWiiGUIControls
{


    class StackPanel : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message 
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }



    /// <summary>
    /// Binary CheckBox control, for visually enhanced checkbox
    /// </summary>
    class CheckBoxEx : CheckBox
    //class derived from the CheckBox class
    {
        //init vars for OnPaint
        private static Brush lightgrayBrush = new SolidBrush(Color.DimGray);
        private static Brush grayBrush = new SolidBrush(Color.Gray);
        private static Brush lightgreenBrush = new SolidBrush(Color.LightGreen);
        private static Brush orangeBrush = new SolidBrush(Color.Orange);
        private static Pen orangePen = new Pen(orangeBrush, 1);

        private bool h;

        public bool IsHighlighted
        {
            get { return h; }
            set { h = value; this.Refresh(); }              //0 orange highlight around the box
        }

        public int aux { get; set; }
        public int rclevel { get; set; }
        public int item { get; set; }

        //default constructor
        public CheckBoxEx() { }

        //we only need to override the OnPaint method 
        //we do our own painting here
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);   //needed
            pe.Graphics.FillRectangle(grayBrush, 0, 0, 15, 14);
            pe.Graphics.FillRectangle(lightgrayBrush, 0, 0, 14, 13);

            if (this.Checked) pe.Graphics.FillRectangle(lightgreenBrush, 0, 0, 14, 13);
            if (h) pe.Graphics.DrawRectangle(orangePen, 0, 0, 14, 13);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

    }
}