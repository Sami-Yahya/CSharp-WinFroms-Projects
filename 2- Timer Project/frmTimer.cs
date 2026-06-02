using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer_Project.Properties;

namespace Timer_Project
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        readonly SoundPlayer AlarmSound = new SoundPlayer(Properties.Resources.alarm_clock);
        readonly SoundPlayer TickingSound = new SoundPlayer(Properties.Resources.ticking_timer);

        private int swSecondsCounter = 0;
        private int swMinutesCounter = 0;
        private int swHoursCounter = 0;
        private int swTicks = 0;

        private int tmSecondsCounter = 0;
        private int tmMinutesCounter = 0;
        private int tmHoursCounter = 0;
        private bool isTimerRunning = false;
        // private bool isMute = false;
        float FontSize = 20;
        bool Growing = true;
        int x_Timerlbl = 134;
        int y_Timerlbl = 178;

        private DateTime EndTime = new DateTime();

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            swSecondsCounter++;

            if (swSecondsCounter == 60)
            {
                swSecondsCounter = 0;
                swMinutesCounter++;
            }

            if (swMinutesCounter == 60)
            {
                swMinutesCounter = 0;
                swHoursCounter++;
            }

            lblStopwatchTitle.Text = $"{swHoursCounter:D2}   :   {swMinutesCounter:D2}   :   {swSecondsCounter:D2}";
        }

        private void btnStartStopwatch_Click(object sender, EventArgs e)
        {
            if (btnStartStopwatch.Text == "Start")
            {
                timerStopwatch.Start();
                timerTicks.Start();
                btnStartStopwatch.Text = "Stop";
                btnStartStopwatch.ForeColor = Color.Red;
                return;
            }

            if (btnStartStopwatch.Text == "Stop")
            {
                timerStopwatch.Stop();
                timerTicks.Stop();
                btnStartStopwatch.Text = "Start";
                btnStartStopwatch.ForeColor = Color.Green;
                return;
            }
        }

        private void btnResetStopwatch_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
            timerTicks.Stop();

            lblStopwatchTitle.Text = "00   :   00   :   00";
            lblTicks.Text = ",  00";
            listBoxLap.Items.Clear();

            swSecondsCounter = 0;
            swMinutesCounter = 0;
            swHoursCounter = 0;

            if (btnStartStopwatch.Text == "Stop")
            {
                btnStartStopwatch.Text = "Start";
                btnStartStopwatch.ForeColor = Color.Green;
            }
        }

        private void timerTicks_Tick(object sender, EventArgs e)
        {
            swTicks++;

            if (swTicks == 100)
                swTicks = 0;

            lblTicks.Text = $",  {swTicks:D2}";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            listBoxLap.Items.Add(lblStopwatchTitle.Text + "  " + lblTicks.Text);
        }

        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            tmSecondsCounter--;

            if (tmSecondsCounter < 0)
            {
                tmSecondsCounter = 59;
                tmMinutesCounter--;
            }

            if (tmMinutesCounter < 0)
            {
                tmMinutesCounter = 59;
                tmHoursCounter--;
            }

            //Change color and size when timer less than 10 seconds
            if (tmSecondsCounter <= 10 && tmMinutesCounter == 0 && tmHoursCounter == 0)
            {
                if (Growing)
                {
                    FontSize += 2;
                    x_Timerlbl = 113;
                    y_Timerlbl = 175;
                    Growing = false;
                }
                else
                {
                    FontSize -= 2;
                    x_Timerlbl = 134;
                    y_Timerlbl = 178;
                    Growing = true;
                }

                lblTimerTitle.ForeColor = Color.Red;
                lblTimerTitle.Font = new Font(lblTimerTitle.Font.FontFamily, FontSize, FontStyle.Bold);
                lblTimerTitle.Location = new Point(x_Timerlbl, y_Timerlbl);
            }

            lblTimerTitle.Text = $"{tmHoursCounter:D2}   :   {tmMinutesCounter:D2}   :   {tmSecondsCounter:D2}";

            if (tmSecondsCounter == 0 && tmMinutesCounter == 0 && tmHoursCounter == 0)
            { 
                timerCountdown.Stop();
                isTimerRunning = false;
                TickingSound.Stop();
                AlarmSound.Play();
                DialogResult result = MessageBox.Show($"Time is up!\nDo you want to restart the timer?", "Timer", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    AlarmSound.Stop();
                    lblTimerTitle.ForeColor = Color.Black;
                    lblTimerTitle.Font = new Font(lblTimerTitle.Font.FontFamily, 20, FontStyle.Regular);
                    lblTimerTitle.Location = new Point(134, 178);
                    btnStartTimer.Text = "Start";
                    btnStartTimer.ForeColor = Color.Green;

                    tmSecondsCounter = (int)numericSeconds.Value;
                    tmMinutesCounter = (int)numericMinutes.Value;
                    tmHoursCounter = (int)numericHours.Value;
                    lblTimerTitle.Text = $"{tmHoursCounter:D2}   :   {tmMinutesCounter:D2}   :   {tmSecondsCounter:D2}";

                    btnStartTimer.PerformClick();
                }
                else
                    btnResetTimer.PerformClick();
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (btnStartTimer.Text == "Start")
            {
                if (tmSecondsCounter == 0 && tmMinutesCounter == 0 && tmHoursCounter == 0)
                {
                    MessageBox.Show("Please enter a time greater than 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                numericSeconds.Enabled = false;
                numericMinutes.Enabled = false;
                numericHours.Enabled = false;

                timerCountdown.Start();
                isTimerRunning = true;

                if (btnMute.Tag.ToString() == "Mute") //status of btnMute, "Mute" = the user didn't press on it
                    TickingSound.PlayLooping();

                lblEndTime.Visible = true;
                lblEndTime.Text = GetEndTime();

                btnStartTimer.Text = "Stop";
                btnStartTimer.ForeColor = Color.Red;
                return;
            }

            if (btnStartTimer.Text == "Stop")
            {
                timerCountdown.Stop();
                isTimerRunning = false;
                TickingSound.Stop();

                lblEndTime.Visible = false;

                btnStartTimer.Text = "Start";
                btnStartTimer.ForeColor = Color.Green;
                return;
            }
        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            isTimerRunning = false;

            lblTimerTitle.Text = "00   :   00   :   00";
            lblTimerTitle.ForeColor = Color.Black;
            lblTimerTitle.Font = new Font(lblTimerTitle.Font.FontFamily, 20, FontStyle.Regular);
            lblTimerTitle.Location = new Point(134, 178);

            tmSecondsCounter = 0;
            tmMinutesCounter = 0;
            tmHoursCounter = 0;

            numericSeconds.Value = 0;
            numericMinutes.Value = 0;
            numericHours.Value = 0;

            numericSeconds.Enabled = true;
            numericMinutes.Enabled = true;
            numericHours.Enabled = true;

            lblEndTime.Visible = false;

            AlarmSound.Stop();
            TickingSound.Stop();

            if (btnStartTimer.Text == "Stop")
            {
                btnStartTimer.Text = "Start";
                btnStartTimer.ForeColor = Color.Green;
            }
        }

        private void numericSeconds_ValueChanged(object sender, EventArgs e)
        {
            tmSecondsCounter = Convert.ToInt32(numericSeconds.Value);
            lblTimerTitle.Text = $"{(int)numericHours.Value:D2}   :   {(int)numericMinutes.Value:D2}   :   {(int)numericSeconds.Value:D2}";
        }

        private void numericMinutes_ValueChanged(object sender, EventArgs e)
        {
            tmMinutesCounter = Convert.ToInt32(numericMinutes.Value);
            lblTimerTitle.Text = $"{(int)numericHours.Value:D2}   :   {(int)numericMinutes.Value:D2}   :   {(int)numericSeconds.Value:D2}";
        }

        private void numericHours_ValueChanged(object sender, EventArgs e)
        {
            tmHoursCounter = Convert.ToInt32(numericHours.Value);
            lblTimerTitle.Text = $"{(int)numericHours.Value:D2}   :   {(int)numericMinutes.Value:D2}   :   {(int)numericSeconds.Value:D2}";
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (btnMute.Tag.ToString() == "Mute")
            {
                TickingSound.Stop();
                btnMute.Tag = "Unmute";
                btnMute.Image = Resources.unmute_48_48;
                return;
            }

            if (btnMute.Tag.ToString() == "Unmute")
            {
                if (isTimerRunning)
                   TickingSound.PlayLooping();

                btnMute.Tag = "Mute";
                btnMute.Image = Resources.mute_48_48;
                return;
            }
        }

        private string GetEndTime()
        {
            EndTime = DateTime.Now.AddHours(tmHoursCounter).AddMinutes(tmMinutesCounter).AddSeconds(tmSecondsCounter);

            return "Ends at: " + EndTime.ToString("HH : mm : ss");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];

                numericHours.Value = int.Parse(item.SubItems[0].Text);
                numericMinutes.Value = int.Parse(item.SubItems[1].Text);
                numericSeconds.Value = int.Parse(item.SubItems[2].Text);

                tabControl1.SelectedTab = tabTimer;
            }
        }
    
    }
}
