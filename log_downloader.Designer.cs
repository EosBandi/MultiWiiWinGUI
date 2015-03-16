namespace MultiWiiWinGUI
{
    partial class log_downloader
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bEraseLogs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bListLogs = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bDownload = new System.Windows.Forms.Button();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 395);
            this.textBox1.TabIndex = 1;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(13, 13);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bEraseLogs
            // 
            this.bEraseLogs.Location = new System.Drawing.Point(13, 100);
            this.bEraseLogs.Name = "bEraseLogs";
            this.bEraseLogs.Size = new System.Drawing.Size(75, 23);
            this.bEraseLogs.TabIndex = 3;
            this.bEraseLogs.Text = "EraseLogs";
            this.bEraseLogs.UseVisualStyleBackColor = true;
            this.bEraseLogs.Click += new System.EventHandler(this.bEraseLogs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // bListLogs
            // 
            this.bListLogs.Location = new System.Drawing.Point(13, 54);
            this.bListLogs.Name = "bListLogs";
            this.bListLogs.Size = new System.Drawing.Size(75, 23);
            this.bListLogs.TabIndex = 5;
            this.bListLogs.Text = "List Logs";
            this.bListLogs.UseVisualStyleBackColor = true;
            this.bListLogs.Click += new System.EventHandler(this.bListLogs_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(13, 467);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(37, 13);
            this.lStatus.TabIndex = 7;
            this.lStatus.Text = "Status";
            // 
            // bDownload
            // 
            this.bDownload.Location = new System.Drawing.Point(343, 29);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(98, 23);
            this.bDownload.TabIndex = 8;
            this.bDownload.Text = "Download LOGS";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(495, 29);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(120, 394);
            this.chkList.TabIndex = 9;
            // 
            // log_downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 492);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bListLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEraseLogs);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "log_downloader";
            this.Text = "log_downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bEraseLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bListLogs;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.CheckedListBox chkList;
    }
}