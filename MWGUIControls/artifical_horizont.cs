
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Data;

namespace MultiWiiGUIControls
{
    class artifical_horizon : MWGUIControl
    {
        #region Fields



        // Parameters
       private double PitchAngle = 0;
	   private double RollAngle = 0; 
       private bool   bIndicatorType      = false;            //normal artifical horizon

        // Images
        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.Horizon_Background);
        Bitmap bmpEmptyBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.Horizon_empty_Background);
        Bitmap bmpHorizon = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.Horizon_GroundSky);
        Bitmap bmpPlane = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.Maquette_Avion);
        Bitmap bmpToggleON = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.toggle_on);
        Bitmap bmpToggleOFF = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.toggle_off);
        Bitmap bmpRoll = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.roll);
        Bitmap bmpPitch = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.pitch);



        #endregion

        #region Contructor

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public artifical_horizon()
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
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            Point ptHorizon_sky = new Point(12, - 105);
            Point ptRotation = new Point(75, 75);

            bmpBackground.MakeTransparent(Color.Yellow);
            bmpEmptyBackground.MakeTransparent(Color.Yellow);
            bmpPlane.MakeTransparent(Color.Yellow);
            bmpRoll.MakeTransparent(Color.Yellow);
            bmpPitch.MakeTransparent(Color.Yellow);

            //Horizon
            Bitmap bmp = new Bitmap(125, 360);
            Graphics gfx = Graphics.FromImage(bmp);
            Pen maskPen = new Pen(this.BackColor, 30);

            if (bIndicatorType == false)
            {

                gfx.TranslateTransform(62f, 180f);
                gfx.RotateTransform((float)(RollAngle));
                gfx.TranslateTransform(-62f, -180f);
                gfx.TranslateTransform(0, (float)PitchAngle * 2);
                gfx.DrawImageUnscaled(bmpHorizon, 0, 0);

                //Draw
                pe.Graphics.DrawImageUnscaled(bmp, 12, -105);
                // diplay mask
                pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpBackground.Width, bmpBackground.Height);
                // display control background
                pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0, (bmpBackground.Width), (bmpBackground.Height));
                // display aircraft symbol
                pe.Graphics.DrawImageUnscaled(bmpPlane, (int)((0.5 * bmpBackground.Width - 0.5 * bmpPlane.Width)), (int)((0.5 * bmpBackground.Height - 0.5 * bmpPlane.Height)), (bmpPlane.Width), (bmpPlane.Height));
                //Display toggle switch
                pe.Graphics.DrawImageUnscaled(bmpToggleOFF, 114, 6);
            }
            else
            {

                //create an empty Bitmap image
                Bitmap bmpRollTemp = new Bitmap(bmpRoll.Width, bmpRoll.Height+50);
                //turn the Bitmap into a Graphics object
                Graphics gfxRoll = Graphics.FromImage(bmpRollTemp);
                //now we set the rotation point to the center of our image
                gfxRoll.TranslateTransform((float)bmpRollTemp.Width / 2, (float)(bmpRollTemp.Height) / 2);
                //now rotate the image
                gfxRoll.RotateTransform(-(float)RollAngle);
                gfxRoll.TranslateTransform(-(float)bmpRollTemp.Width / 2, -(float)(bmpRollTemp.Height) / 2);
                //now draw our new image onto the graphics object
                gfxRoll.DrawImage(bmpRoll, new Point(0, 25));
                //dispose of our Graphics object
                gfxRoll.Dispose();

                Bitmap bmpPitchTemp = new Bitmap(bmpPitch.Width, bmpPitch.Height + 50);
                //turn the Bitmap into a Graphics object
                Graphics gfxPitch = Graphics.FromImage(bmpPitchTemp);
                //now we set the rotation point to the center of our image
                gfxPitch.TranslateTransform((float)bmpPitchTemp.Width / 2, (float)(bmpPitchTemp.Height) / 2);
                //now rotate the image
                gfxPitch.RotateTransform(-(float)PitchAngle);
                gfxPitch.TranslateTransform(-(float)bmpPitchTemp.Width / 2, -(float)(bmpPitchTemp.Height) / 2);
                //now draw our new image onto the graphics object
                gfxPitch.DrawImage(bmpPitch, new Point(0, 25));
                //dispose of our Graphics object
                gfxPitch.Dispose();




                // diplay mask
                pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpBackground.Width, bmpBackground.Height);
                // display control background
                pe.Graphics.DrawImageUnscaled(bmpEmptyBackground, 0, 0, (bmpBackground.Width), (bmpBackground.Height));
                //Display toggle switch
                pe.Graphics.DrawImageUnscaled(bmpToggleON, 114, 6);
                //Draw roll
                pe.Graphics.DrawImageUnscaled(bmpRollTemp, 35, 11);
                //Draw pitch
                pe.Graphics.DrawImageUnscaled(bmpPitchTemp, 35, 71);
               
                bmpRollTemp.Dispose();
                bmpPitchTemp.Dispose();

            }

            gfx.Dispose();
            bmp.Dispose();
            maskPen.Dispose();


        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftPitchAngle">The aircraft pitch angle in °deg</param>
        /// <param name="aircraftRollAngle">The aircraft roll angle in °deg</param
        public void SetArtificalHorizon(double aircraftPitchAngle, double aircraftRollAngle)
        {
            PitchAngle = aircraftPitchAngle;
            RollAngle = aircraftRollAngle;

            this.Refresh();
        }


        public void SetArtificalHorizonType(bool type)
        {
            bIndicatorType = type;
            this.Refresh();
        }

        public void ToggleArtificalHorizonType()
        {
            bIndicatorType = !bIndicatorType;
            this.Refresh();
        }


        #endregion

    }
}
