namespace MultiWiiWinGUI
{
    partial class setup_wizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setup_wizard));
            this.b_finish_cancel = new System.Windows.Forms.Button();
            this.b_prev = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.tabFinish = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.cb_LogEnabled = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Log10 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_Log9 = new System.Windows.Forms.CheckBox();
            this.cb_Log3 = new System.Windows.Forms.CheckBox();
            this.cb_Log8 = new System.Windows.Forms.CheckBox();
            this.cb_Log1 = new System.Windows.Forms.CheckBox();
            this.cb_Log7 = new System.Windows.Forms.CheckBox();
            this.cb_Log2 = new System.Windows.Forms.CheckBox();
            this.cb_Log6 = new System.Windows.Forms.CheckBox();
            this.cb_Log4 = new System.Windows.Forms.CheckBox();
            this.cb_Log5 = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabFolders = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.b_select_captures_folder = new System.Windows.Forms.Button();
            this.l_Captures_folder = new System.Windows.Forms.Label();
            this.b_select_settings_folder = new System.Windows.Forms.Button();
            this.l_Settings_folder = new System.Windows.Forms.Label();
            this.b_select_log_folder = new System.Windows.Forms.Button();
            this.l_Log_folder = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_SerialSpeed = new System.Windows.Forms.ComboBox();
            this.cb_SerialPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelWizard = new MultiWiiGUIControls.StackPanel();
            this.tabSpeech = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSpeechEnabled = new System.Windows.Forms.CheckBox();
            this.tabFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelWizard.SuspendLayout();
            this.tabSpeech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_finish_cancel
            // 
            this.b_finish_cancel.Location = new System.Drawing.Point(498, 18);
            this.b_finish_cancel.Name = "b_finish_cancel";
            this.b_finish_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_finish_cancel.TabIndex = 1;
            this.b_finish_cancel.Text = "Cancel";
            this.b_finish_cancel.UseVisualStyleBackColor = true;
            this.b_finish_cancel.Click += new System.EventHandler(this.b_finish_cancel_Click);
            // 
            // b_prev
            // 
            this.b_prev.Location = new System.Drawing.Point(336, 18);
            this.b_prev.Name = "b_prev";
            this.b_prev.Size = new System.Drawing.Size(75, 23);
            this.b_prev.TabIndex = 2;
            this.b_prev.Text = "Previous";
            this.b_prev.UseVisualStyleBackColor = true;
            this.b_prev.Click += new System.EventHandler(this.b_prev_Click);
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(417, 18);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(75, 23);
            this.b_next.TabIndex = 3;
            this.b_next.Text = "Next";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // tabFinish
            // 
            this.tabFinish.BackColor = System.Drawing.Color.DimGray;
            this.tabFinish.Controls.Add(this.label12);
            this.tabFinish.Controls.Add(this.label6);
            this.tabFinish.Controls.Add(this.pictureBox6);
            this.tabFinish.Location = new System.Drawing.Point(4, 22);
            this.tabFinish.Name = "tabFinish";
            this.tabFinish.Size = new System.Drawing.Size(588, 292);
            this.tabFinish.TabIndex = 5;
            this.tabFinish.Text = "tabPage6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(155, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(427, 128);
            this.label12.TabIndex = 10;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(153, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thank You !";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_6;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(148, 294);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // tabLogs
            // 
            this.tabLogs.BackColor = System.Drawing.Color.DimGray;
            this.tabLogs.Controls.Add(this.cb_LogEnabled);
            this.tabLogs.Controls.Add(this.label11);
            this.tabLogs.Controls.Add(this.label5);
            this.tabLogs.Controls.Add(this.panel1);
            this.tabLogs.Controls.Add(this.pictureBox5);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(588, 292);
            this.tabLogs.TabIndex = 4;
            this.tabLogs.Text = "tabPage5";
            // 
            // cb_LogEnabled
            // 
            this.cb_LogEnabled.AutoSize = true;
            this.cb_LogEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_LogEnabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_LogEnabled.Location = new System.Drawing.Point(178, 127);
            this.cb_LogEnabled.Name = "cb_LogEnabled";
            this.cb_LogEnabled.Size = new System.Drawing.Size(140, 20);
            this.cb_LogEnabled.TabIndex = 11;
            this.cb_LogEnabled.Text = "Start log at connect";
            this.cb_LogEnabled.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(155, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(392, 64);
            this.label11.TabIndex = 10;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(153, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Logging";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_Log10);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cb_Log9);
            this.panel1.Controls.Add(this.cb_Log3);
            this.panel1.Controls.Add(this.cb_Log8);
            this.panel1.Controls.Add(this.cb_Log1);
            this.panel1.Controls.Add(this.cb_Log7);
            this.panel1.Controls.Add(this.cb_Log2);
            this.panel1.Controls.Add(this.cb_Log6);
            this.panel1.Controls.Add(this.cb_Log4);
            this.panel1.Controls.Add(this.cb_Log5);
            this.panel1.Location = new System.Drawing.Point(178, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 123);
            this.panel1.TabIndex = 34;
            // 
            // cb_Log10
            // 
            this.cb_Log10.AutoSize = true;
            this.cb_Log10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log10.Location = new System.Drawing.Point(198, 93);
            this.cb_Log10.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log10.Name = "cb_Log10";
            this.cb_Log10.Size = new System.Drawing.Size(58, 17);
            this.cb_Log10.TabIndex = 32;
            this.cb_Log10.Text = "Debug";
            this.cb_Log10.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(8, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "DataSets";
            // 
            // cb_Log9
            // 
            this.cb_Log9.AutoSize = true;
            this.cb_Log9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log9.Location = new System.Drawing.Point(198, 72);
            this.cb_Log9.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log9.Name = "cb_Log9";
            this.cb_Log9.Size = new System.Drawing.Size(140, 17);
            this.cb_Log9.TabIndex = 31;
            this.cb_Log9.Text = "Cycle, I2CErrors, Battery";
            this.cb_Log9.UseVisualStyleBackColor = true;
            // 
            // cb_Log3
            // 
            this.cb_Log3.AutoSize = true;
            this.cb_Log3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log3.Location = new System.Drawing.Point(75, 51);
            this.cb_Log3.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log3.Name = "cb_Log3";
            this.cb_Log3.Size = new System.Drawing.Size(119, 17);
            this.cb_Log3.TabIndex = 25;
            this.cb_Log3.Text = "Mag and Barometer";
            this.cb_Log3.UseVisualStyleBackColor = true;
            // 
            // cb_Log8
            // 
            this.cb_Log8.AutoSize = true;
            this.cb_Log8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log8.Location = new System.Drawing.Point(198, 51);
            this.cb_Log8.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log8.Name = "cb_Log8";
            this.cb_Log8.Size = new System.Drawing.Size(71, 17);
            this.cb_Log8.TabIndex = 30;
            this.cb_Log8.Text = "GPS Nav";
            this.cb_Log8.UseVisualStyleBackColor = true;
            // 
            // cb_Log1
            // 
            this.cb_Log1.AutoSize = true;
            this.cb_Log1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log1.Location = new System.Drawing.Point(75, 9);
            this.cb_Log1.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log1.Name = "cb_Log1";
            this.cb_Log1.Size = new System.Drawing.Size(114, 17);
            this.cb_Log1.TabIndex = 23;
            this.cb_Log1.Text = "RAW Sensor Data";
            this.cb_Log1.UseVisualStyleBackColor = true;
            // 
            // cb_Log7
            // 
            this.cb_Log7.AutoSize = true;
            this.cb_Log7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log7.Location = new System.Drawing.Point(198, 30);
            this.cb_Log7.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log7.Name = "cb_Log7";
            this.cb_Log7.Size = new System.Drawing.Size(59, 17);
            this.cb_Log7.TabIndex = 29;
            this.cb_Log7.Text = "Servos";
            this.cb_Log7.UseVisualStyleBackColor = true;
            // 
            // cb_Log2
            // 
            this.cb_Log2.AutoSize = true;
            this.cb_Log2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log2.Location = new System.Drawing.Point(75, 30);
            this.cb_Log2.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log2.Name = "cb_Log2";
            this.cb_Log2.Size = new System.Drawing.Size(119, 17);
            this.cb_Log2.TabIndex = 24;
            this.cb_Log2.Text = "Attitude (Roll, Pitch)";
            this.cb_Log2.UseVisualStyleBackColor = true;
            // 
            // cb_Log6
            // 
            this.cb_Log6.AutoSize = true;
            this.cb_Log6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log6.Location = new System.Drawing.Point(198, 9);
            this.cb_Log6.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log6.Name = "cb_Log6";
            this.cb_Log6.Size = new System.Drawing.Size(58, 17);
            this.cb_Log6.TabIndex = 28;
            this.cb_Log6.Text = "Motors";
            this.cb_Log6.UseVisualStyleBackColor = true;
            // 
            // cb_Log4
            // 
            this.cb_Log4.AutoSize = true;
            this.cb_Log4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log4.Location = new System.Drawing.Point(75, 72);
            this.cb_Log4.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log4.Name = "cb_Log4";
            this.cb_Log4.Size = new System.Drawing.Size(82, 17);
            this.cb_Log4.TabIndex = 26;
            this.cb_Log4.Text = "RC Controls";
            this.cb_Log4.UseVisualStyleBackColor = true;
            // 
            // cb_Log5
            // 
            this.cb_Log5.AutoSize = true;
            this.cb_Log5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Log5.Location = new System.Drawing.Point(75, 93);
            this.cb_Log5.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log5.Name = "cb_Log5";
            this.cb_Log5.Size = new System.Drawing.Size(112, 17);
            this.cb_Log5.TabIndex = 27;
            this.cb_Log5.Text = "RC AUX channels";
            this.cb_Log5.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_5;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(148, 294);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // tabFolders
            // 
            this.tabFolders.BackColor = System.Drawing.Color.DimGray;
            this.tabFolders.Controls.Add(this.label22);
            this.tabFolders.Controls.Add(this.label21);
            this.tabFolders.Controls.Add(this.label20);
            this.tabFolders.Controls.Add(this.b_select_captures_folder);
            this.tabFolders.Controls.Add(this.l_Captures_folder);
            this.tabFolders.Controls.Add(this.b_select_settings_folder);
            this.tabFolders.Controls.Add(this.l_Settings_folder);
            this.tabFolders.Controls.Add(this.b_select_log_folder);
            this.tabFolders.Controls.Add(this.l_Log_folder);
            this.tabFolders.Controls.Add(this.label10);
            this.tabFolders.Controls.Add(this.label4);
            this.tabFolders.Controls.Add(this.pictureBox4);
            this.tabFolders.Location = new System.Drawing.Point(4, 22);
            this.tabFolders.Name = "tabFolders";
            this.tabFolders.Size = new System.Drawing.Size(588, 292);
            this.tabFolders.TabIndex = 3;
            this.tabFolders.Text = "tabPage4";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(176, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 16);
            this.label22.TabIndex = 21;
            this.label22.Text = "Log folder";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(176, 200);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "Video captures folder";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(176, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(262, 16);
            this.label20.TabIndex = 19;
            this.label20.Text = "Parameter settings  and Mission files folder\r\n";
            // 
            // b_select_captures_folder
            // 
            this.b_select_captures_folder.Location = new System.Drawing.Point(483, 215);
            this.b_select_captures_folder.Name = "b_select_captures_folder";
            this.b_select_captures_folder.Size = new System.Drawing.Size(44, 27);
            this.b_select_captures_folder.TabIndex = 18;
            this.b_select_captures_folder.Text = "...";
            this.b_select_captures_folder.UseVisualStyleBackColor = true;
            this.b_select_captures_folder.Click += new System.EventHandler(this.b_select_captures_folder_Click);
            // 
            // l_Captures_folder
            // 
            this.l_Captures_folder.BackColor = System.Drawing.Color.Gray;
            this.l_Captures_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Captures_folder.ForeColor = System.Drawing.Color.White;
            this.l_Captures_folder.Location = new System.Drawing.Point(179, 217);
            this.l_Captures_folder.Name = "l_Captures_folder";
            this.l_Captures_folder.Padding = new System.Windows.Forms.Padding(1);
            this.l_Captures_folder.Size = new System.Drawing.Size(304, 23);
            this.l_Captures_folder.TabIndex = 17;
            this.l_Captures_folder.Text = "label19";
            this.l_Captures_folder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_select_settings_folder
            // 
            this.b_select_settings_folder.Location = new System.Drawing.Point(483, 136);
            this.b_select_settings_folder.Name = "b_select_settings_folder";
            this.b_select_settings_folder.Size = new System.Drawing.Size(44, 27);
            this.b_select_settings_folder.TabIndex = 16;
            this.b_select_settings_folder.Text = "...";
            this.b_select_settings_folder.UseVisualStyleBackColor = true;
            this.b_select_settings_folder.Click += new System.EventHandler(this.b_select_settings_folder_Click);
            // 
            // l_Settings_folder
            // 
            this.l_Settings_folder.BackColor = System.Drawing.Color.Gray;
            this.l_Settings_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Settings_folder.ForeColor = System.Drawing.Color.White;
            this.l_Settings_folder.Location = new System.Drawing.Point(179, 138);
            this.l_Settings_folder.Name = "l_Settings_folder";
            this.l_Settings_folder.Padding = new System.Windows.Forms.Padding(1);
            this.l_Settings_folder.Size = new System.Drawing.Size(304, 23);
            this.l_Settings_folder.TabIndex = 15;
            this.l_Settings_folder.Text = "label16";
            this.l_Settings_folder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_select_log_folder
            // 
            this.b_select_log_folder.Location = new System.Drawing.Point(483, 175);
            this.b_select_log_folder.Name = "b_select_log_folder";
            this.b_select_log_folder.Size = new System.Drawing.Size(44, 27);
            this.b_select_log_folder.TabIndex = 12;
            this.b_select_log_folder.Text = "...";
            this.b_select_log_folder.UseVisualStyleBackColor = true;
            this.b_select_log_folder.Click += new System.EventHandler(this.b_select_log_folder_Click);
            // 
            // l_Log_folder
            // 
            this.l_Log_folder.BackColor = System.Drawing.Color.Gray;
            this.l_Log_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Log_folder.ForeColor = System.Drawing.Color.White;
            this.l_Log_folder.Location = new System.Drawing.Point(179, 177);
            this.l_Log_folder.Name = "l_Log_folder";
            this.l_Log_folder.Padding = new System.Windows.Forms.Padding(1);
            this.l_Log_folder.Size = new System.Drawing.Size(304, 23);
            this.l_Log_folder.TabIndex = 11;
            this.l_Log_folder.Text = "label15";
            this.l_Log_folder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(155, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Please choose where WinGUI save captured video files,\r\nLog files, Parameter setti" +
    "ngs and Missions.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(153, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Folders";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_4;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 294);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // tabSerial
            // 
            this.tabSerial.BackColor = System.Drawing.Color.DimGray;
            this.tabSerial.Controls.Add(this.label14);
            this.tabSerial.Controls.Add(this.label13);
            this.tabSerial.Controls.Add(this.cb_SerialSpeed);
            this.tabSerial.Controls.Add(this.cb_SerialPort);
            this.tabSerial.Controls.Add(this.label9);
            this.tabSerial.Controls.Add(this.label3);
            this.tabSerial.Controls.Add(this.pictureBox3);
            this.tabSerial.Location = new System.Drawing.Point(4, 22);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Size = new System.Drawing.Size(588, 292);
            this.tabSerial.TabIndex = 2;
            this.tabSerial.Text = "tabPage3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(251, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "PORT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(371, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "SPEED";
            // 
            // cb_SerialSpeed
            // 
            this.cb_SerialSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SerialSpeed.FormattingEnabled = true;
            this.cb_SerialSpeed.Location = new System.Drawing.Point(374, 186);
            this.cb_SerialSpeed.Name = "cb_SerialSpeed";
            this.cb_SerialSpeed.Size = new System.Drawing.Size(89, 21);
            this.cb_SerialSpeed.TabIndex = 10;
            // 
            // cb_SerialPort
            // 
            this.cb_SerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SerialPort.FormattingEnabled = true;
            this.cb_SerialPort.Location = new System.Drawing.Point(254, 186);
            this.cb_SerialPort.Name = "cb_SerialPort";
            this.cb_SerialPort.Size = new System.Drawing.Size(79, 21);
            this.cb_SerialPort.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(155, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 80);
            this.label9.TabIndex = 8;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(153, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preferred Serial Comms";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 294);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tabStart
            // 
            this.tabStart.BackColor = System.Drawing.Color.DimGray;
            this.tabStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStart.Controls.Add(this.label7);
            this.tabStart.Controls.Add(this.label1);
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(588, 292);
            this.tabStart.TabIndex = 0;
            this.tabStart.Text = "tabPage1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(155, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 176);
            this.label7.TabIndex = 3;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the MultiWii WinGUI!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 294);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelWizard
            // 
            this.panelWizard.Controls.Add(this.tabStart);
            this.panelWizard.Controls.Add(this.tabSerial);
            this.panelWizard.Controls.Add(this.tabFolders);
            this.panelWizard.Controls.Add(this.tabSpeech);
            this.panelWizard.Controls.Add(this.tabLogs);
            this.panelWizard.Controls.Add(this.tabFinish);
            this.panelWizard.Location = new System.Drawing.Point(-4, 44);
            this.panelWizard.Margin = new System.Windows.Forms.Padding(0);
            this.panelWizard.Name = "panelWizard";
            this.panelWizard.Padding = new System.Drawing.Point(0, 0);
            this.panelWizard.SelectedIndex = 0;
            this.panelWizard.Size = new System.Drawing.Size(596, 318);
            this.panelWizard.TabIndex = 0;
            // 
            // tabSpeech
            // 
            this.tabSpeech.BackColor = System.Drawing.Color.DimGray;
            this.tabSpeech.Controls.Add(this.cbSpeechEnabled);
            this.tabSpeech.Controls.Add(this.label8);
            this.tabSpeech.Controls.Add(this.label2);
            this.tabSpeech.Controls.Add(this.pictureBox2);
            this.tabSpeech.Location = new System.Drawing.Point(4, 22);
            this.tabSpeech.Name = "tabSpeech";
            this.tabSpeech.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeech.Size = new System.Drawing.Size(588, 292);
            this.tabSpeech.TabIndex = 6;
            this.tabSpeech.Text = "tabPage1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MultiWiiWinGUI.Properties.Resources.wizard_7;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.InitialImage = global::MultiWiiWinGUI.Properties.Resources.wizard_7;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 294);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(167, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enable Spoken notifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(168, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 64);
            this.label8.TabIndex = 9;
            this.label8.Text = "During navigation, certain events could generate\r\nspoken notifications. You can a" +
    "lso set periodic\r\nannouncement of certain telemetry values.\r\n\r\n";
            // 
            // cbSpeechEnabled
            // 
            this.cbSpeechEnabled.AutoSize = true;
            this.cbSpeechEnabled.Checked = true;
            this.cbSpeechEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpeechEnabled.ForeColor = System.Drawing.Color.White;
            this.cbSpeechEnabled.Location = new System.Drawing.Point(171, 134);
            this.cbSpeechEnabled.Name = "cbSpeechEnabled";
            this.cbSpeechEnabled.Size = new System.Drawing.Size(156, 17);
            this.cbSpeechEnabled.TabIndex = 10;
            this.cbSpeechEnabled.Text = "Enable spoken notifications";
            this.cbSpeechEnabled.UseVisualStyleBackColor = true;
            // 
            // setup_wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(585, 360);
            this.ControlBox = false;
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.panelWizard);
            this.Controls.Add(this.b_prev);
            this.Controls.Add(this.b_finish_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setup_wizard";
            this.Text = "MultiWii WinGUI Settings Wizard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.setup_wizard_Load);
            this.tabFinish.ResumeLayout(false);
            this.tabFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabFolders.ResumeLayout(false);
            this.tabFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelWizard.ResumeLayout(false);
            this.tabSpeech.ResumeLayout(false);
            this.tabSpeech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_finish_cancel;
        private System.Windows.Forms.Button b_prev;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.TabPage tabFinish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.CheckBox cb_LogEnabled;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_Log10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cb_Log9;
        private System.Windows.Forms.CheckBox cb_Log3;
        private System.Windows.Forms.CheckBox cb_Log8;
        private System.Windows.Forms.CheckBox cb_Log1;
        private System.Windows.Forms.CheckBox cb_Log7;
        private System.Windows.Forms.CheckBox cb_Log2;
        private System.Windows.Forms.CheckBox cb_Log6;
        private System.Windows.Forms.CheckBox cb_Log4;
        private System.Windows.Forms.CheckBox cb_Log5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage tabFolders;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button b_select_captures_folder;
        private System.Windows.Forms.Label l_Captures_folder;
        private System.Windows.Forms.Button b_select_settings_folder;
        private System.Windows.Forms.Label l_Settings_folder;
        private System.Windows.Forms.Button b_select_log_folder;
        private System.Windows.Forms.Label l_Log_folder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_SerialSpeed;
        private System.Windows.Forms.ComboBox cb_SerialPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MultiWiiGUIControls.StackPanel panelWizard;
        private System.Windows.Forms.TabPage tabSpeech;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbSpeechEnabled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;

    }
}