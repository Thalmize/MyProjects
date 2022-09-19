using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Transactions;
using System.IO;

namespace BillibleHoursClock
{
    public partial class MainClocking : Form
    {
        public MainClocking()
        {
            InitializeComponent();
            
        }

        // Global items
        public static byte totalEntries = 0;
        public static string[] logs;
        public static string currentProject;
        public static bool isThereCurrentProject;
        public static string currentMode = "Stopwatch";

        decimal ratePerHour = 0;
        decimal Total;

        string companyToBill = " ";
        string workDescription = " ";

        // Declares multiplke classes
        static private readonly Watch watch1 = new Watch();
        static private TimeSpan ts = new TimeSpan();
        static private Calculation calc = new Calculation();
        static private TxtFile txtFile = new TxtFile();
        static private Entry entry = new Entry();

        private void Form1_Load(object sender, EventArgs e)
        {
            // on-load sets main function buttons to false and sets current mode as default
            lblStartStop.Enabled = false;
            lblSave.Enabled = false;
            lblReset.Enabled = false;
            lblCurrentMode.Text = $"Mode: {currentMode}";
            lblNewEntryStarted.Visible = false;
        }
        private void lblStartStop_Click(object sender, EventArgs e)
        {
            // Start stop switch based on if new entry was started
            // if entry is started then can start watch otherwise stopwatch will not go

            if (Entry.newEntryStarted)
            {
                if (watch1.IsWatchRunning)
                {
                    watch1.StopWatch();
                    lblStartStop.Text = "Start";
                    lblStartStop.BackColor = Color.Red;
                }
                else
                {
                    watch1.StartWatch();
                    lblStartStop.Text = "Stop";
                    lblStartStop.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("You need to start a new entry before the stopwatch!");
            }
            
            
        }
        
        private void lblSave_Click(object sender, EventArgs e)
        {
            if(watch1.IsWatchRunning)
            {
                MessageBox.Show("Sorry you need to stop the watch to save your information");
            }
            else
            {
                const string message = "Are you sure you want to save this timelog?";
                const string caption = "Saving";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ratePerHour = Convert.ToDecimal(txtbxRate.Text);
                        companyToBill = txtbxBillingCompany.Text;
                        workDescription = txtbxDescriptionofWork.Text;
                        string time = calc.addUpHours(ts);
                        string totalBill = calc.totalRate(Convert.ToDecimal(time), Convert.ToDecimal(txtbxRate.Text));
                        TxtFile file = new TxtFile();
                        file.writeTimeLog(txtbxBillingCompany.Text, ratePerHour, txtbxDescriptionofWork.Text, time.ToString(), totalBill.ToString());

                        MessageBox.Show("Information saved!");
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                    }
                    
                }

            }
        }
        private void lblReset_Click(object sender, EventArgs e)
        {
            // reset switch with couple params, wont reset if watch is active

            if (watch1.IsWatchRunning)
            {
                MessageBox.Show("Sorry you need to stop the watch to reset the clock and information");
            }
            else
            {
                if (currentMode == "Stopwatch")
                {
                    watch1.ResetWatch();
                }
                else
                {
                    txtbxRate.Clear();
                    txtbxDescriptionofWork.Clear();
                    txtbxTotalTime.ReadOnly = true;
                }
                
            }
            if(!Entry.wasEntrySaved)
            {
                DialogResult dr = MessageBox.Show("Your new entry has not been saved! Are you sure you want to reset? *You will lose all data not saved*", "Save Entry", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //reset
                    Entry.newEntryStarted = false;
                    lblNewEntryStarted.Visible = true;

                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("New Project aborted!");
                }

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ts = watch1.HowMuchTimehasPassed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            lblStopwatch.Text = elapsedTime;
        }

        private void lblNewEntry_Click(object sender, EventArgs e)
        {
            if (watch1.IsWatchRunning)
            {
                MessageBox.Show("Sorry a new entry is not possible while the stopwatch is running!");
            }
            else if(!isThereCurrentProject)
            {
                MessageBox.Show("Project has not started! Either create a new project or load a project!");
            }
            else if(Entry.newEntryStarted)
            {
                MessageBox.Show("You just started a new entry! Save or reset this entry to continue");
            }
            else
            {
                if (currentMode == "Stopwatch")
                {
                    txtbxTotalTime.ReadOnly = true;
                }
                else txtbxTotalTime.ReadOnly = false;

                Entry.newEntryStarted = true;
                Entry.wasEntrySaved = false;
                totalEntries++;
                txtbxEntry.Text = totalEntries.ToString();
                if (Entry.newEntryStarted)
                {
                    lblNewEntryStarted.Visible = true;
                }
            }


        }

        private void lblUpdateEntry_Click(object sender, EventArgs e)
        {

        }

        private void lblNewProject_Click(object sender, EventArgs e)
        {
            // Starting a new project log, checks for if there is a project active.
            // with no project active will create txt log for starting to input entry.

            if (isThereCurrentProject != true)
            {
                DialogResult dr = MessageBox.Show("You chose to start a new project? Are you sure you want to continue? *NOTE: when saving file for project, that will also be your billing company!*", "New Project", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        lblCurrentProject.Text = txtFile.startProject();
                        txtbxBillingCompany.Text = currentProject;
                        totalEntries = 0;
                        txtbxEntry.Text = totalEntries.ToString();
                    }
                    else if (dr == DialogResult.No)
                    {
                        MessageBox.Show("New Project aborted!");
                    }
            }
            else
            {
                MessageBox.Show("Sorry there is currently a project open! Please close the current project before starting a new project!");
            }

            // enables the buttons after starting a new project successfully!

            lblStartStop.Enabled = true;
            lblSave.Enabled = true;
            lblReset.Enabled = true;
        }

        private void lblLoadProject_Click(object sender, EventArgs e)
        {
            // Loading project action, checks if there is an active project
            // then will load rows of data.

            if (MainClocking.isThereCurrentProject != true)
            {
                (lblCurrentProject.Text, logs) = txtFile.loadProject();
                
                foreach (var log in logs)
                {
                    txtbxClockingInfo.AppendText(log + Environment.NewLine);
                    totalEntries++;
                   
                }
            }
            else
            {
                MessageBox.Show("Sorry there is a current project already loaded! Please close current project before loading another project!");
            }

            txtbxEntry.Text = totalEntries.ToString();
            txtbxBillingCompany.Text = currentProject;

            lblStartStop.Enabled = true;
            lblSave.Enabled = true;
            lblReset.Enabled = true;
        }

        private void lblCloseProject_Click(object sender, EventArgs e)
        {
            // will close project if one is active and will clear out all fields

            if (MainClocking.isThereCurrentProject != true)
            {
                MessageBox.Show("There is no project open to close. Please open a project to get started.");
            }
            else
            {
                currentProject = "No Current Project";
                lblCurrentProject.Text = currentProject;
                isThereCurrentProject = false;
                totalEntries = 0;

                txtbxEntry.Clear();
                txtbxBillingCompany.Clear();
                txtbxRate.Clear();
                txtbxDescriptionofWork.Clear();
                txtbxTotalTime.Clear();
                txtbxClockingInfo.Clear();

                lblStartStop.Enabled = false;
                lblSave.Enabled = false;
                lblReset.Enabled = false;

                MessageBox.Show("Project successfully closed!");
            }

        }

        private void lblCurrentMode_Click(object sender, EventArgs e)
        {
            // Changes modes based on click action

            if (currentMode == "Stopwatch")
            {
                currentMode = "Manual Entry";
                lblCurrentMode.Text = $"Mode: {currentMode}";
            }
            else
            {
                currentMode = "Stopwatch";
                lblCurrentMode.Text = $"Mode: {currentMode}";
            }
            
            // updates txt box to be readable based on mode switch

            if (Entry.newEntryStarted && currentMode == "Stopwatch")
            {
                txtbxTotalTime.ReadOnly = true;
            }
            else if (Entry.newEntryStarted && currentMode == "Manual Entry")
            {
                txtbxTotalTime.ReadOnly = false;
            }
        }
    }
}
