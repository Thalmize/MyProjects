using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsProgram
{
    class CreatingItems
    {
        public CreatingItems()
        {

        }

      public System.Windows.Forms.Label TestLbl()
        {
           System.Windows.Forms.Label testlabel = new System.Windows.Forms.Label();

            testlabel.Size = new System.Drawing.Size(100, 50);
            testlabel.Location = new System.Drawing.Point(500, 500);
            testlabel.Text = "this is a test";
            testlabel.ForeColor = System.Drawing.Color.White;

            return testlabel;
        }
    }

    
}
