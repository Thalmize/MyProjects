using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Clock_Timer
{
    public partial class Timer_Main : Form
    {
        public Timer_Main()
        {
            InitializeComponent();
        }
        //time 
        double timerMin;
        double timerSec;
        double breakTimerMin;
        double breakTimerSec;

        SoundPlayer player;

        //bool
        bool isTimerRunning;
        bool isBreakTimerRunning;
        bool isTimeonCurrentTimer;
        bool isTimeonBreakTimer;
        
        private void Timer_Main_Load(object sender, EventArgs e)
        {
            timerMin = 00;
            timerSec = 00;
            breakTimerMin = 00;
            breakTimerSec = 00;

            UpdatingVariables();

            TimeMin.Text = timerMin.ToString();
            TimeSec.Text = timerSec.ToString();
            breakMin.Text = breakTimerMin.ToString();
            breakSec.Text = breakTimerSec.ToString();

            btnStop.Visible = false;
            btnReset.Visible = true;
            lblDone.Visible = false;

            cbSetTime.SelectedIndex = 0;
            player = new SoundPlayer("timerhorn.wav");
        }
        public void UpdatingVariables()
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                if (timerSec >= 60)
                {
                    timerMin = timerMin + 1;
                    timerSec = 0;
                }

                if (timerMin <= 9)
                {
                    TimeMin.Text = "0" + timerMin.ToString();
                }
                else TimeMin.Text = timerMin.ToString();


                if (timerSec <= 9)
                {
                    TimeSec.Text = "0" + timerSec.ToString();
                }
                else TimeSec.Text = timerSec.ToString();
            }
            else
            {
                if (breakTimerSec >= 60)
                {
                    breakTimerMin = breakTimerMin + 1;
                    breakTimerSec = 0;
                }

                if (breakTimerMin <= 9)
                {
                    breakMin.Text = "0" + breakTimerMin.ToString();
                }
                else breakMin.Text = breakTimerMin.ToString();


                if (breakTimerSec <= 9)
                {
                    breakSec.Text = "0" + breakTimerSec.ToString();
                }
                else breakSec.Text = breakTimerSec.ToString();
            }

        }
        private bool isTimeBelowZero(double time)
        {
            if (time < 0)
                return true;
            else return false;
        }
        
        private void btnplus10min_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerMin = timerMin + 10;
            }
            else
            {
                breakTimerMin = breakTimerMin + 10;
            }
            UpdatingVariables();
        }

        private void btnplus1min_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerMin = timerMin + 1;
            }
            else
            {
                breakTimerMin = breakTimerMin + 1;
            }
            UpdatingVariables();

        }

        private void btnminus10min_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerMin = timerMin - 10;
            }
            else
            {
                breakTimerMin = breakTimerMin - 10;
            }
            UpdatingVariables();
        }

        private void btnminus1min_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerMin = timerMin - 1;
            }
            else
            {
                breakTimerMin = breakTimerMin - 1;
                
            }
            UpdatingVariables();
        }

        private void btnplus10sec_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerSec = timerSec + 10;
            }
            else
            {
                breakTimerSec = breakTimerSec + 10;
            }
            UpdatingVariables();
        }

        private void btnplus1sec_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerSec = timerSec + 1;
            }
            else
            {
                breakTimerSec = breakTimerSec + 1;
            }
            UpdatingVariables();
        }

        private void btnminus10sec_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerSec = timerSec - 10;
            }
            else
            {
                breakTimerSec = breakTimerSec - 10;
               
            }
            UpdatingVariables();
        }

        private void btnminus1sec_Click(object sender, EventArgs e)
        {
            if (cbSetTime.SelectedIndex == 0)
            {
                timerSec = timerSec - 1;
            }
            else
            {
                breakTimerSec = breakTimerSec - 1;
            }
            UpdatingVariables();
        }

        private bool isThereTimeonTimer(double timeMin, double timeSec)
        {
            if (timeMin > 0 || timeSec > 0)
                return true;
            else return false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            isTimeonCurrentTimer = isThereTimeonTimer(timerMin, timerSec);
            isTimeonBreakTimer = isThereTimeonTimer(breakTimerMin, breakTimerSec);

            if (!isTimeonCurrentTimer && isTimeonBreakTimer)
            {
                MessageBox.Show("You do not have any time on current timer. You can not start without time on current timer.");
            }
            else if(!isTimeonCurrentTimer)
            {
                MessageBox.Show("Sorry but there is no time on the current timer");
                currentTimer.Stop();
            }
            else
            {
                currentTimer.Start();
            }
            
            BackColor = Color.DarkGreen;
            lblminchoice.Visible = false;
            lblsecchoice.Visible = false;

            
            
            btnStop.Visible = true;
            btnStart.Visible = false;
            btnReset.Visible = false;
            btnminus10min.Visible = false;
            btnminus1min.Visible = false;
            btnminus1sec.Visible = false;
            btnminus10sec.Visible = false;

            btnplus1sec.Visible = false;
            btnplus10sec.Visible = false;
            btnplus1min.Visible = false;
            btnplus10min.Visible = false;

            WindowState = FormWindowState.Minimized;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            currentTimer.Stop();
            BackColor = Color.MistyRose;
            btnStart.Visible = true;
            btnReset.Visible = true;
            btnminus10min.Visible = true;
            btnminus1min.Visible = true;
            btnminus1sec.Visible = true;
            btnminus10sec.Visible = true;

            btnplus1sec.Visible = true;
            btnplus10sec.Visible = true;
            btnplus1min.Visible = true;
            btnplus10min.Visible = true;

            lblDone.Visible = false;
            lblsecchoice.Visible = true;
            lblminchoice.Visible = true;

            player.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(cbSetTime.SelectedIndex == 0)
            {
                timerMin = 00;
                timerSec = 00;
            }
            else
            {
                breakTimerMin = 00;
                breakTimerSec = 00;
            }
            UpdatingVariables();
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            
            if (timerSec == 0)
            {

                if (timerMin != 0)
                {
                    timerMin = timerMin - 1;
                    timerSec = 60;
                }
            }
            timerSec--;

            if (timerMin == 0 && timerSec == 0)
            {
                currentTimer.Stop();
                lblDone.Visible = true;
                BackColor = Color.Blue;
                player.Play();
            }
            if (timerMin <= 9)
            {
                TimeMin.Text = "0" + timerMin.ToString();
            }
            else
            {
                TimeMin.Text = timerMin.ToString();
            }
            if (timerSec <= 9)
            {
                TimeSec.Text = "0" + timerSec.ToString();

            }
            else
            {
                TimeSec.Text = timerSec.ToString();

            }
            isTimeonBreakTimer = isThereTimeonTimer(breakTimerMin, breakTimerSec);
            isTimeonCurrentTimer = isThereTimeonTimer(timerMin, timerSec);

            if (!isTimeonCurrentTimer)
            {
                currentTimer.Stop();
                breakTimer.Start();
                UpdatingVariables();
                lblDone.Visible = true;
                lblDone.Text = "Current timer is over, Start break";
                BackColor = Color.Blue;
                player.Play();
                breakTimer.Start();
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            
            if (breakTimerSec == 0)
            {

                if (breakTimerMin != 0)
                {
                    breakTimerMin = breakTimerMin - 1;
                    breakTimerSec = 60;
                }
            }
            breakTimerSec--;

                
            if (breakTimerMin <= 9)
            {
                breakMin.Text = "0" + breakTimerMin.ToString();
            }
            else
            {
                breakMin.Text = breakTimerMin.ToString();
            }
            if (breakTimerSec <= 9)
            {
                breakSec.Text = "0" + breakTimerSec.ToString();

            }
            else
            {
                breakSec.Text = breakTimerSec.ToString();

            }

            isTimeonBreakTimer = isThereTimeonTimer(breakTimerMin, breakTimerSec);

            if (!isTimeonBreakTimer)
            {
                breakTimer.Stop();
                currentTimer.Stop();
                lblDone.Visible = true;
                lblDone.Text = "Break Timer has stopped";
                BackColor = Color.Red;
                player.Play();
                timerMin = 00;
                timerSec = 00;
                breakTimerMin = 00;
                breakTimerSec = 00;
                WindowState = FormWindowState.Normal;
            }

        }
    }
}
