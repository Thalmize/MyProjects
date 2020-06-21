using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MattProject_CardCollection_
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        private void txtbxSubmit_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            while (true)
            {
               if (Information.AdminClearance.username != txtbxALusername.Text)
                {
                    lblNotes.Text = "Sorry this is not your username!";
                    break;

                }
                else
                {
                    if (Information.AdminClearance.password != txtbxALpassword.Text)
                    {
                        lblNotes.Text = "Sorry this is not your password!";
                        break;

                    }
                    else
                    {
                        lblNotes.Text = "Your credientials are working fine!";
                        Information.AdminClearance.Clearance = true;

                        this.Close();
                        break;
                        
                        

                    }
                }
                
            }
            

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbxALusername.Text = "";
            txtbxALpassword.Text = "";

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
        }

    }
}
