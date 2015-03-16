using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Data;

namespace MultiWiiGUIControls
{
    class indicator_lamp : MWGUIControl
    {
        #region Fields

        // Parameters
        [Description("Indicator Color"),Category("Apperance"),DefaultValue(0),Browsable(true)]
        public int indicator_color {get; set;}            //Green default (1-red);
        [Description("Indicator Status"), Category("Apperance"), DefaultValue(false), Browsable(true)]
        public bool status {get; set;}                 //off
        //No need for properties since it's overrided
        public override string Text {get; set;}
 
        // Images

        Bitmap bmpRedOff = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.i_red_off);
        Bitmap bmpRedOn = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.i_red_on);
        Bitmap bmpGreenOff = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.i_green_off);
        Bitmap bmpGreenOn = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.i_green_on);


        #endregion

        #region Contructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public indicator_lamp()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
           
        }

        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.Height = 17;
            this.Width = 50;
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrushOrange = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            System.Drawing.SolidBrush drawBrushWhite = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushDim = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);

            bmpRedOff.MakeTransparent(Color.Yellow);
            bmpRedOn.MakeTransparent(Color.Yellow);
            bmpGreenOff.MakeTransparent(Color.Yellow);
            bmpGreenOn.MakeTransparent(Color.Yellow);

            if (indicator_color == 0)
            {
                if (status)
                {
                    pe.Graphics.DrawImageUnscaled(bmpGreenOn, 0, 0);
                }
                else
                {
                    pe.Graphics.DrawImageUnscaled(bmpGreenOff, 0, 0);
                }
            }
            else
            {
                if (status)
                {
                    pe.Graphics.DrawImageUnscaled(bmpRedOn, 0, 0);
                }
                else
                {
                    pe.Graphics.DrawImageUnscaled(bmpRedOff, 0, 0);
                }

            }
            SizeF stringSize = new SizeF();
            stringSize = pe.Graphics.MeasureString(Text, drawFont);
            if (status)
            {
                if (indicator_color == 0)
                {
                    pe.Graphics.DrawString(Text, drawFont, drawBrushWhite, 1 + (63 - stringSize.Width) / 2, (15 - stringSize.Height) / 2);
                }
                else
                {
                    pe.Graphics.DrawString(Text, drawFont, drawBrushOrange, 1 + (63 - stringSize.Width) / 2, (15 - stringSize.Height) / 2);
                }
            }
            else
            {
                pe.Graphics.DrawString(Text, drawFont, drawBrushDim, 1 + (63 - stringSize.Width) / 2, (15 - stringSize.Height) / 2);
            }

            //Dispose objects
            drawFont.Dispose();
            drawBrushDim.Dispose();
            drawBrushOrange.Dispose();
            drawBrushWhite.Dispose();

        }


        #endregion

        #region Methods


        public void SetStatus(bool value)
        {
            status = value;
            this.Refresh();
        }

        public bool GetStatus()
        {
            return status;
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(65, 17);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 65, 17, specified);
        }


        #endregion
    }
}
