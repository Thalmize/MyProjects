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

namespace testApp
{
    public partial class DataExplorer : Form
    {
        public DataExplorer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Mechanism.Variables.Path;
            FBD.ShowDialog();
            Mechanism.Variables.FilePath = FBD.SelectedPath;
            Mechanism.Variables.FileName = Path.GetFileName(FBD.SelectedPath);

            Mechanism mech = new Mechanism();
            mech.GetEmpName();

            txtbxFirstName.Text = Mechanism.Variables.Emp[0];
            txtbxLastName.Text = Mechanism.Variables.Emp[1];
            txtbxNum.Text = Mechanism.Variables.Emp[2];
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo DI = new DirectoryInfo(Mechanism.Variables.FilePath);
            FileInfo[] Files = DI.GetFiles();
            foreach (var file in Files)
            {
                txtbxTEST.AppendText(file.ToString());
                txtbxTEST.AppendText(Environment.NewLine);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxNum.Clear();
            txtbxTEST.Clear();

            Mechanism.Variables.Emp[0] = null;
            Mechanism.Variables.Emp[1] = null;
            Mechanism.Variables.Emp[2] = null;
            Mechanism.Variables.FileName = null;
            Mechanism.Variables.FilePath = null;

        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowDialog();
            Mechanism.Variables.Path = FBD.SelectedPath;
            txtbxFile.Text = Mechanism.Variables.Path;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
