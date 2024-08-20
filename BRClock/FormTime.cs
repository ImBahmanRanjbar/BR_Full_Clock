using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRClock
{
    public partial class FormTime : Form
    {
        public FormTime()
        {
            InitializeComponent();
        }

        private void FormTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Today.ToString();
            label2.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToLongTimeString().ToString().Contains("ب.ظ"))
            {
                label1.Text = "بعد از ظهر";
            }
            else if (DateTime.Now.ToLongTimeString().ToString().Contains("ق.ظ"))
            {
                label1.Text = "قبل از ظهر";
            }
            label4.Text = DateTime.Now.ToString("dddd");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
