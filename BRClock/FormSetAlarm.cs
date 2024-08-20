using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRClock
{
    public partial class FormSetAlarm : Form
    {

        public FormSetAlarm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "Running...";
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;

        }

        private void FormSetAlarm_Load(object sender, EventArgs e)
        {



        }



        private void BtnStop_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop_Click_1(object sender, EventArgs e)
        {
            label1.Text = "STOP";
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            p.Stop();
        }
        SoundPlayer p = new SoundPlayer(Properties.Resources.Alarm01);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            DateTime Alarmtimr = dateTimePicker1.Value;
            if (currenTime.Hour == Alarmtimr.Hour && currenTime.Minute == Alarmtimr.Minute && currenTime.Second == Alarmtimr.Second)
            {
                timer1.Stop();
                
                p.PlayLooping();
            }
        }

        private void FormSetAlarm_Load_1(object sender, EventArgs e)
        {
            BtnStop.Enabled = false;
        }
    }
}
