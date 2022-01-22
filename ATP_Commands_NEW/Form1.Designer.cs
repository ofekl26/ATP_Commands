using System.IO.Ports;
using System.Collections.Generic;


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
            this.StartBtn = new System.Windows.Forms.Button();
            this.ComDevicesCb = new System.Windows.Forms.ComboBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.timeTb = new System.Windows.Forms.TextBox();
            this.PortLogTb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 44);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(133, 45);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ComDevicesCb
            // 
            this.ComDevicesCb.FormattingEnabled = true;
            this.ComDevicesCb.Location = new System.Drawing.Point(12, 17);
            this.ComDevicesCb.Name = "ComDevicesCb";
            this.ComDevicesCb.Size = new System.Drawing.Size(427, 21);
            this.ComDevicesCb.TabIndex = 1;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(160, 44);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(133, 45);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(306, 44);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(133, 45);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(725, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(63, 31);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 91);
            this.textBox2.TabIndex = 6;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(445, 146);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(343, 31);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // timeTb
            // 
            this.timeTb.Enabled = false;
            this.timeTb.Location = new System.Drawing.Point(445, 209);
            this.timeTb.Multiline = true;
            this.timeTb.Name = "timeTb";
            this.timeTb.Size = new System.Drawing.Size(343, 229);
            this.timeTb.TabIndex = 8;
            // 
            // PortLogTb
            // 
            this.PortLogTb.HideSelection = false;
            this.PortLogTb.Location = new System.Drawing.Point(12, 95);
            this.PortLogTb.Multiline = true;
            this.PortLogTb.Name = "PortLogTb";
            this.PortLogTb.Size = new System.Drawing.Size(427, 343);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PortLogTb);
            this.Controls.Add(this.timeTb);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.ComDevicesCb);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.TextBox timeTb;
        private System.Windows.Forms.TextBox PortLogTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer2;
    }
}

