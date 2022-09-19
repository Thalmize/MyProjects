using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.IO;
using System.Windows.Forms;

namespace BillibleHoursClock
{
    class TxtFile
    {
        public TxtFile() { }

        Calculation calc = new Calculation();
        
        public void writeTimeLog(string billingCompany, decimal rate, string workDescription, string minutes, string totalBill)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            sfd.Title = "Save Timelog";
            sfd.DefaultExt = ".txt";
            sfd.FileName = billingCompany;

            File.WriteAllText(sfd.FileName + ".txt", billingCompany + "|" + rate.ToString() + "|" + workDescription + "|" + minutes + "|" + totalBill);
            
        }
        public string startProject()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            sfd.Title = "Save Timelog";
            sfd.DefaultExt = ".txt";
            sfd.ShowDialog();
            var hold = Path.GetFileName(sfd.FileName).Split('.');
            MainClocking.currentProject = hold[0];
            MainClocking.isThereCurrentProject = true;
            File.Create(sfd.FileName);

            return MainClocking.currentProject;

        }
        public Tuple<string, string[]> loadProject()
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            var hold = Path.GetFileName(ofd.FileName).Split('.');
            MainClocking.currentProject = hold[0];
            MainClocking.isThereCurrentProject = true;

            try
            {
                MainClocking.logs = File.ReadAllLines(ofd.FileName);
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new Tuple<string, string[]>(MainClocking.currentProject, MainClocking.logs);
        }
        public void openTimeLog()
        {
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string[] lines = new string[1000];
            currentFileOpen = Path.GetFileName(ofd.FileName);
           
            try
            {
                lines = File.ReadAllLines(ofd.FileName);

                MainClocking.logs = readTimeLog(lines);
                

            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
        /*
        public string[,] readTimeLog(string[] logs)
        {
            
            string[,] logInformation = new string[100, 7];
            byte entry = (byte)logs.Length;
            byte x = 0;
            while (x < entry)
            {
                foreach (string log in logs)
                {
                    string[] temps = log.Split('|');
                    logInformation[x, 0] = temps[0]; // Entry Number
                    logInformation[x, 1] = temps[1]; // Company Name
                    logInformation[x, 2] = temps[2]; // Rate per hour
                    logInformation[x, 3] = temps[3]; // Description
                    logInformation[x, 4] = temps[4]; // Total Hours
                    logInformation[x, 5] = temps[5]; // Total Money
                }
                MainClocking.totalEntries++;
                x++;
            }
            
            return logInformation;
            
        }
        */

    }
}
