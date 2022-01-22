using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Net.NetworkInformation;

namespace ATP_Commands_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ComDevicesCb.Text);
            if (this.ComDevicesCb.Text == "")
            {
                this.PortLogTb.Text = "No Port Selected";
            }
            else
            {
                this.PortLogTb.Text = "";
                this.timeTb.Text = "";
                //this.serialPort1.PortName = this.ComDevicesCb.Text.Split('(', ')')[1];
                string portname = this.ComDevicesCb.Text.Split('(', ')')[1].Split(' ')[0] + this.ComDevicesCb.Text.Split('(', ')')[1].Split(' ')[1];
                Console.WriteLine("chosen port: " +portname);
                this.serialPort1.PortName = portname;
                this.serialPort1.Open();
                File.AppendAllText("ATCommands_output.txt", "\r\n\r\nTest started at " + DateTime.Now.ToString() + "\r\n\r\n");
                File.AppendAllText("Ping_output.txt", "\r\n\r\nTest started at " + DateTime.Now.ToString() + "\r\n\r\n");
                this.timer1.Enabled = true;
                this.timer2.Enabled = true;
                for (int index = 0; index < 3; ++index)
                    this.responses[index] = "";
                    Console.Write("oy");
                this.StartBtn.Enabled = false;
                this.timeTb.Enabled = true;
            }
        }
        
        private void StopBtn_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            this.serialPort1.Close();
            this.StartBtn.Enabled = true;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("getting ports");
            getComPorts();
            Console.WriteLine("got ports");
        }

        private void PortLogTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            this.BeginInvoke(new MethodInvoker(() => { this.PortLogTb.Text = ""; } ));
            Parallel.For(0, this.ComDevicesCb.Items.Count, (Action<int, ParallelLoopState>)((i, loopState) =>
            {
                PingReply reply = new Ping().Send(this.ComDevicesCb.Items[i].ToString());
                this.BeginInvoke(new MethodInvoker(() => { this.PortLogTb.AppendText(this.ComDevicesCb.Items[i].ToString() + (reply.Status == IPStatus.Success ? " Alive, RTT :" + reply.RoundtripTime.ToString() : " Dead") + "\r\n\r\n"); }));
            }));
            this.BeginInvoke(new MethodInvoker(() => { this.timeTb.AppendText(DateTime.Now.ToString()); })) ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.sent && !this.sentAll)
            {
                this.serialPort1.Write(this.commands[this.WaitingForResponseNo - 1]);
                this.sent = true;
                if (this.WaitingForResponseNo == 3)
                    this.sentAll = true;
                else
                    this.sentAll = false;
            }
            else
            {
                if (!this.sentAll || this.WaitingForResponseNo != 4)
                    return;
                this.sentAll = false;
                this.PortLogTb.Clear();
                string str1 = "";
                for (int index = 0; index < 3; ++index)
                {
                    this.PortLogTb.AppendText(this.responses[index]);
                    str1 += this.responses[index];
                }
                TextBox PortLogTb = this.PortLogTb;
                DateTime now = DateTime.Now;
                string text = now.ToString();
                PortLogTb.AppendText(text);
                string str2 = str1;
                now = DateTime.Now;
                string str3 = now.ToString();
                File.AppendAllText("ATCommands_output.txt", str2 + str3);
                this.WaitingForResponseNo = 1;
            }
        }

            private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!this.sent)
            {
                return;
            }
            this.responses[this.WaitingForResponseNo - 1] = ((SerialPort)sender).ReadTo("OK");
            this.sent = false;
            ++this.WaitingForResponseNo;
        }
    }
}
