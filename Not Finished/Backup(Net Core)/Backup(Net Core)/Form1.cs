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
using static System.Console;
using System.Windows.Forms.Design;
using System.DirectoryServices;
using System.Windows.Forms.VisualStyles;
using System.Reflection;
using System.Threading;

namespace Backup_Net_Core_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string backupStartLocation = "C:/Users/" + Environment.UserName + "/Desktop/Dummy";
        
        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            Variables.destination = fbd.SelectedPath;
            txtbxDestination.Text = Variables.destination;
            txtbxResults.AppendText("Destination: " + Variables.destination);
            txtbxResults.AppendText(Environment.NewLine);
        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            Stack<string> directory = new Stack<string>(100);

            
            directory.Push(backupStartLocation);
            while(directory.Count > 0)
            {
                string[] subDir;
                string currentDir = directory.Pop();

                subDir = System.IO.Directory.GetDirectories(currentDir);
                DirectoryInfo DI = new DirectoryInfo(currentDir);
                string path = Variables.destination + "/"+ DI.Name;
                System.IO.Directory.CreateDirectory(path);

                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }
                catch { }
                foreach (string file in files)
                {
                    FileInfo FI = new FileInfo(file);
                    string write = currentDir + " : " + FI.Name;
                    txtbxResults.AppendText(write);
                    txtbxResults.AppendText(Environment.NewLine);
                    

                }
                foreach (string str in subDir)
                {
                    directory.Push(str);
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        
    }
}
