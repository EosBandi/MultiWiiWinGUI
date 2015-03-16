namespace MultiWiiWinGUI
{
    partial class splash_screen
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
            this.l_version = new System.Windows.Forms.Label();
            this.l_full_version = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_mwver = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_version
            // 
            this.l_version.BackColor = System.Drawing.Color.Gray;
            this.l_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_version.ForeColor = System.Drawing.Color.LightGray;
            this.l_version.Location = new System.Drawing.Point(452, 77);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(132, 18);
            this.l_version.TabIndex = 0;
            this.l_version.Text = "Version 2.3 Beta";
            this.l_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_full_version
            // 
            this.l_full_version.AutoSize = true;
            this.l_full_version.BackColor = System.Drawing.Color.Gray;
            this.l_full_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_full_version.ForeColor = System.Drawing.Color.Black;
            this.l_full_version.Location = new System.Drawing.Point(502, 254);
            this.l_full_version.Name = "l_full_version";
            this.l_full_version.Size = new System.Drawing.Size(86, 15);
            this.l_full_version.TabIndex = 1;
            this.l_full_version.Text = "1.0.0000.0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(383, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "by András Schäffer (EOSBandi)";
            // 
            // l_mwver
            // 
            this.l_mwver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mwver.ForeColor = System.Drawing.Color.Maroon;
            this.l_mwver.Location = new System.Drawing.Point(386, 123);
            this.l_mwver.Name = "l_mwver";
            this.l_mwver.Size = new System.Drawing.Size(200, 50);
            this.l_mwver.TabIndex = 5;
            this.l_mwver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(2, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(91, 16);
            this.lStatus.TabIndex = 6;
            this.lStatus.Text = "asdasdcasdc";
            // 
            // splash_screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(598, 278);
            this.ControlBox = false;
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.l_mwver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.l_full_version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 280);
            this.Name = "splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Label l_full_version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_mwver;
        private System.Windows.Forms.Label lStatus;

    }
}