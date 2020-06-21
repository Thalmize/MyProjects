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
    class Mechanism
    {
        public Mechanism() { }

        internal static class Variables
        {
            public static string[] Emp = new string[3];
            public static string Path;
            public static string FileName;
            public static string FilePath;
        }
        public void GetEmpName()
        {
          
            string[] temp2 = Variables.FileName.Split(',');
            Variables.Emp = temp2[1].Split(' ');
            //temp3[0] is a blank
            //Emp[0] - Last Name
            //Emp[1] - First Name
            //Emp[2] - Emp Num
            Variables.Emp[0] = temp2[0];

            
        }
    }
    
}
