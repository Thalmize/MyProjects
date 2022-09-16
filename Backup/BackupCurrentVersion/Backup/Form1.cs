using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Backup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FilePathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            Variables.filepath = fbd.SelectedPath;
            txtbxFilePath.Text = Variables.filepath;
            txtbxresults.Text = "Filepath: " + Variables.filepath;
            txtbxresults.Text = Environment.NewLine;


        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            Variables.destination = fbd.SelectedPath;
            txtbxDestination.Text = Variables.destination;
            txtbxresults.Text = "Destination: " + Variables.destination;
            txtbxresults.Text = Environment.NewLine;


        }

        private void BtnStartBackup_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd = new ProcessStartInfo("CMD.exe");
            Process cmd2 = new Process();
            string command = "Robocopy /S /E /R:5 /W:5 " + Variables.filepath + " " + Variables.destination;
            cmd.RedirectStandardInput = false;
            cmd.UseShellExecute = true;
            cmd.Arguments = "/user:Administrator \"cmd /K " + command + "\"";
            cmd.WorkingDirectory = Variables.filepath;
            cmd.Verb = "runas";

            cmd2.StartInfo = cmd;
            cmd2.Start();
            /*
            cmd2.StandardInput.WriteLine("Robocopy /S /E /R:5 /W:5 " + Variables.filepath + " " + Variables.destination);
            
            cmd2.StandardInput.Flush();
            cmd2.StandardInput.Close();
            cmd2.WaitForExit();
            */
            txtbxresults.Text = "backup complete";
            
        }
    }
}
