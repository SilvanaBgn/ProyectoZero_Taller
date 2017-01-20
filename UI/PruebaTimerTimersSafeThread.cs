using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace UI
{
    public partial class PruebaTimerTimersSafeThread : Form
    {
        private System.Timers.Timer iTimerBanner;

        public PruebaTimerTimersSafeThread()
        {
            InitializeComponent();
            this.iTimerBanner = new System.Timers.Timer();

            this.iTimerBanner.AutoReset = false;
            this.iTimerBanner.Elapsed += new ElapsedEventHandler(timerBanner_Elapsed);
            this.iTimerBanner.Interval = 10000;
            this.iTimerBanner.Enabled = true;
            this.label1.Text = "";
        }

        private void timerBanner_Elapsed(Object source, ElapsedEventArgs e)
        {
            this.iTimerBanner.Stop();
            this.SetText("h");
            this.iTimerBanner.Interval = 2000;
            this.iTimerBanner.Start();
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text += text;
            }
        }

        private void PruebaTimerTimers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.iTimerBanner.Stop();
            this.iTimerBanner.Dispose();
        }
    }
}
