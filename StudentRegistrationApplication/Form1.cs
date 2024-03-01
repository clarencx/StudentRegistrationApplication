using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int DaY = 1;
            while (DaY <= 31)
            {
                comboBox1.Items.Add(DaY);
                DaY++;
            }

            int MonNth = 1;
            while (MonNth <= 12)
            {
                comboBox2.Items.Add(MonNth);
                MonNth++;
            }

            int YeAr = 1900;
            while (YeAr <= 2024)
            {
                comboBox3.Items.Add(YeAr);
                YeAr++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
