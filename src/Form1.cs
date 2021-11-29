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

namespace Countdown
{
    public partial class Countdow : System.Windows.Forms.Form
    {
        CountdownViewModel countdown = new CountdownViewModel();
        public Countdow()
        {
            InitializeComponent();
            this.timer.Enabled = false;
            secondsBox.ReadOnly = true;
            minutesBox.ReadOnly = true;
            hoursBox.ReadOnly = true;
            lapRichBox.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(countdown.Seconds.ToString().Length < 2)
            {
                secondsBox.Text = "0" + countdown.Seconds.ToString();
                countdown.Seconds += 1;
            }
            else
            {
                secondsBox.Text = countdown.Seconds.ToString();
                countdown.Seconds += 1;
            }
 

            if (secondsBox.Text == "60")
            {
                timer.Interval = 1;
                secondsBox.Text = "00";

                if(countdown.Minutes.ToString().Length < 2)
                {
                    minutesBox.Text = "0" + countdown.Minutes.ToString();
                }
                else
                {
                    minutesBox.Text = countdown.Minutes.ToString();
                }
                
                countdown.Seconds = 1;
                countdown.Minutes += 1;
                timer.Interval = 1000;
            }

            if(minutesBox.Text == "60")
            {
                timer.Interval = 1;
                minutesBox.Text = "00";

                if (countdown.Hours.ToString().Length < 2)
                {
                    hoursBox.Text = "0" + countdown.Hours.ToString();
                }
                else
                {
                    hoursBox.Text = countdown.Hours.ToString();
                }

                countdown.Minutes = 1;
                countdown.Hours += 1;
                timer.Interval = 1000;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
            secondsBox.Text = "00";
            minutesBox.Text = "00";
            hoursBox.Text = "00";
            countdown.Seconds = 0;
            countdown.Minutes = 0;
            countdown.Hours = 0;
            lapRichBox.ResetText();
        }

        private void lapButton_Click(object sender, EventArgs e)
        {
            lapRichBox.AppendText(hoursBox.Text + ":" + minutesBox.Text + ":" + secondsBox.Text);
            lapRichBox.AppendText("\n");
        }
    }
}
