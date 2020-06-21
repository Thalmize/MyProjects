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
using System.Drawing.Imaging;
namespace MattProject_CardCollection_
{
    public partial class TestScanner : Form
    {
        public TestScanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw objbarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pbbarcode.Image = objbarcode.Draw(txtbxInput.Text, 160, 2
                
                );
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }
    }
}
