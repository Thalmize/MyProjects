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

namespace AlertTimer
{
    public partial class AlertTimer : Form
    {
        public AlertTimer()
        {
            InitializeComponent();
        }

        //time
        double min;
        double sec;

        SoundPlayer player;

        private void Timer_Load(object sender, EventArgs e)
        {
            min = 0;
            sec = 0;
            UpdatingVariables();

            TimeMin.Text = min.ToString();
            TimeSec.Text = sec.ToString();

            btnStop.Visible = false;
            btnReset.Visible = true;
            lblDone.Visible = false;

            player = new SoundPlayer("timerhorn.wav");

        }

        private void btnplus1sec_Click(object sender, EventArgs e)
        {
            sec = sec + 1;
            UpdatingVariables();
        }

        private void btnminus1sec_Click(object sender, EventArgs e)
        {
            sec = sec - 1;
            UpdatingVariables();

            if (sec < 0)
            {
                MessageBox.Show("Sorry you can not subtract from 0");
                sec = 0;
                UpdatingVariables();
            }
        }

        private void btnplus10sec_Click(object sender, EventArgs e)
        {
            sec = sec + 10;
            UpdatingVariables();
        }

        private void btnminus10sec_Click(object sender, EventArgs e)
        {
            sec = sec - 10;
            UpdatingVariables();
            if (sec < 0)
            {
                MessageBox.Show("Sorry you can not subtract from 0");
                sec = 0;
                UpdatingVariables();
            }
        }

        private void btnminus1min_Click(object sender, EventArgs e)
        {
            min = min - 1;
            UpdatingVariables();

            if (min < 0)
            {
                MessageBox.Show("Sorry you can not subtract from 0");
                min = 0;
                UpdatingVariables();
            }
        }
        private void btnminus10min_Click(object sender, EventArgs e)
        {
            min = min - 10;
            UpdatingVariables();

            if (min < 0)
            {
                MessageBox.Show("Sorry you can not subtract from 0");
                min = 0;
                UpdatingVariables();
            }
        }

        private void btnplus1min_Click(object sender, EventArgs e)
        {
            min = min + 1;
            UpdatingVariables();
        }

        private void btnplus10min_Click(object sender, EventArgs e)
        {
            min = min + 10;
            UpdatingVariables();
        }

        public void UpdatingVariables()
        {
            if (sec >= 60)
            {
                min = min + 1;
                sec = 0;
            }

            if (min <= 9)
            {
                TimeMin.Text = "0" + min.ToString();
            }
            else TimeMin.Text = min.ToString();


            if (sec <= 9)
            {
                TimeSec.Text = "0" + sec.ToString();
            }
            else TimeSec.Text = sec.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            BackColor = Color.DarkGreen;
            lblminchoice.Visible = false;
            lblsecchoice.Visible = false;

            if (min == 0 && sec == 0)
            {
                MessageBox.Show("Sorry you need to add time to the timer");
                timer1.Stop();
                min = 0;
                sec = 0;
                UpdatingVariables();

            }

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



        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {

                if (min != 0)
                {
                    min = min - 1;
                    sec = 60;
                }
            }
            sec--;

            if (min == 0 && sec == 0)
            {
                timer1.Stop();
                lblDone.Visible = true;
                BackColor = Color.Red;
                player.Play();
            }
            if (min <= 9)
            {
                TimeMin.Text = "0" + min.ToString();
            }
            else
            {
                TimeMin.Text = min.ToString();
            }
            if (sec <= 9)
            {
                TimeSec.Text = "0" + sec.ToString();

            }
            else
            {
                TimeSec.Text = sec.ToString();

            }



        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            min = 0;
            sec = 0;
            UpdatingVariables();

        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }
    }
}
    
