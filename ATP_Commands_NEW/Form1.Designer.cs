using System.IO.Ports;
using System.Collections.Generic;
using CustomControls_TelleCollege ;


namespace ATP_Commands_NEW
{ 
    partial class Form1
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
        protected void getComPorts()
        {
            System.Console.WriteLine("getting com ports");   
            List<string> comPorts = new List<string>();
            string[] spPorts = SerialPort.GetPortNames();
            this.ComDevicesCb.Items.Clear();
            
            if (spPorts != null)
            {
                System.Console.WriteLine("spPorts are not null");
                System.Console.WriteLine(spPorts);
                for (int i = 0; i < spPorts.Length; i++)
                {
                    if (spPorts[i] == "COM36")
                    {
                        comPorts.Add("Quectel USB DM Port (COM 36)");
                    }
                    else if (spPorts[i] == "COM38") {
                        comPorts.Add("Quectel USB AT Port (COM 38)");
                    }
                    else if (spPorts[i] == "COM35")
                    {
                        comPorts.Add("Quectel USB NMEA Port (COM 35)");
                    }
                }
            }
            this.ComDevicesCb.Items.AddRange(comPorts.ToArray());
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBtn = new System.Windows.Forms.Button();
            this.ComDevicesCb = new System.Windows.Forms.ComboBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.PortLogTb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.topBar1 = new CustomControls_TelleCollege.TopBar();
            this.closeButton1 = new CustomControls_TelleCollege.CloseButton();
            this.minimizeButton1 = new CustomControls_TelleCollege.MinimizeButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(361, 367);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(78, 30);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ComDevicesCb
            // 
            this.ComDevicesCb.FormattingEnabled = true;
            this.ComDevicesCb.Location = new System.Drawing.Point(361, 340);
            this.ComDevicesCb.Name = "ComDevicesCb";
            this.ComDevicesCb.Size = new System.Drawing.Size(78, 21);
            this.ComDevicesCb.TabIndex = 1;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(361, 433);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(78, 29);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(361, 400);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(78, 30);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // timeTb
            // 
            this.timeTb.Enabled = false;
            this.timeTb.Location = new System.Drawing.Point(12, 340);
            this.timeTb.Multiline = true;
            this.timeTb.Name = "timeTb";
            this.timeTb.Size = new System.Drawing.Size(343, 122);
            this.timeTb.TabIndex = 8;
            // 
            // PortLogTb
            // 
            this.PortLogTb.HideSelection = false;
            this.PortLogTb.Location = new System.Drawing.Point(483, 47);
            this.PortLogTb.Multiline = true;
            this.PortLogTb.Name = "PortLogTb";
            this.PortLogTb.Size = new System.Drawing.Size(305, 415);
            this.PortLogTb.TabIndex = 9;
            this.PortLogTb.TextChanged += new System.EventHandler(this.PortLogTb_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // topBar1
            // 
            this.topBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar1.Location = new System.Drawing.Point(2, -5);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(760, 49);
            this.topBar1.TabIndex = 10;
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.FlatAppearance.BorderSize = 0;
            this.closeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton1.Location = new System.Drawing.Point(767, 4);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(21, 23);
            this.closeButton1.TabIndex = 11;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton1.FlatAppearance.BorderSize = 0;
            this.minimizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton1.Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeButton1.Location = new System.Drawing.Point(746, 2);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(21, 23);
            this.minimizeButton1.TabIndex = 12;
            this.minimizeButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 287);
            this.dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "../Title.png";
            this.pictureBox1.Location = new System.Drawing.Point(323, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.PortLogTb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.timeTb);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.ComDevicesCb);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.topBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private const int NoCommands = 3;
        private bool sent = false;
        private bool sentAll = false;
        private int WaitingForResponseNo = 1;
        private string[] commands = new string[3]
        {
            "AT+QENG=\"servingcell\"\r\n",
            "AT+QENG=\"neighbourcell\"\r\n",
            "AT+QNWINFO\r\n",
        };
        private string[] responses = new string[3];
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ComboBox ComDevicesCb;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox timeTb;
        private System.Windows.Forms.TextBox PortLogTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer2;
        private CustomControls_TelleCollege.TopBar topBar1;
        private CustomControls_TelleCollege.CloseButton closeButton1;
        private CustomControls_TelleCollege.MinimizeButton minimizeButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

