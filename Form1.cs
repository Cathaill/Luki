using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            CB1.Visible = false;
            CB2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void doprogramu_Click(object sender, EventArgs e)
        {
            daneCB.Text = String.Empty;


            if (checkBox1.Checked)
            {                
                daneCB.Text += "0x0CF00400UL | ID_XTD, prog_TACHO_TORQUE,                           /* - RPM ELOAD ------------------------- */\n";
                daneCB1.Text += "coś tu bedzie\n";
            }

            if (checkBox2.Checked)
            {
                daneCB.Text += "0x18FEDF00UL | ID_XTD, prog_ACCEL_POS,                              /* - ACCEL_POS ------------------------- */\n";
            }
            
             if (checkBox3.Checked)
            {
                daneCB.Text += "0x18FEDF00UL | ID_XTD, prog_ACCEL_POS,                              /* - ACCEL_POS ------------------------- */\n";
            }
            Clipboard.GetData (daneCB.Text);
            MessageBox.Show("Copy");
            
        }

        private void CB1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}





//Clipboard.SetText("0x0CF00400UL | ID_XTD, prog_TACHO_TORQUE,                           /* - RPM ELOAD ------------------------- */");      
