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
    public partial class FormStopWatch : Form
    {
        public FormStopWatch()
        {
            InitializeComponent();
        }
        int ms = 0, s = 0, m = 0, h = 0, num = 1;

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (BtnStop.Tag == "Flag")
            {
                UC_RecordStopWatch record = new UC_RecordStopWatch();
                record.LblNum.Text = (num++).ToString("00");
                record.LblRecord.Text = LblTimer.Text;
                try
                {
                    record.LblRecordD.Text = $"+{Convert.ToDateTime(LblTimer.Text) - dt}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                flowLayoutPanel1.Controls.Add(record);
                dt = Convert.ToDateTime(LblTimer.Text);
            }
            else
            {
                ms = m = s = h = 0;
                num = 1;

                LblTimer.Text = $"{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}";
                BtnPlay.Image = Properties.Resources.play;
                BtnPlay.Tag = "Play";
                BtnStop.Image = Properties.Resources.stop;
                BtnStop.Tag = "Stop";
                flowLayoutPanel1.Controls.Clear();
                dt = Convert.ToDateTime("00:00:00");
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (BtnPlay.Tag == "Play")
            {
                BtnPlay.Image = Properties.Resources.paussse;
                BtnPlay.Tag = "Pause";
                BtnStop.Image = Properties.Resources.flag;
                BtnStop.Tag = "Flag";
                timer.Start();
            }
            else
            {
                BtnPlay.Image = Properties.Resources.play;
                BtnPlay.Tag = "Play";
                BtnStop.Image = Properties.Resources.stop;
                BtnStop.Tag = "Stop";
                timer.Stop();
            }
        }

        DateTime dt = Convert.ToDateTime("00:00:00");
        private void timer_Tick(object sender, EventArgs e)
        {

            s++;
            LblTimer.Text = $"{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}";
            if (s == 60)
            {
                s = 0;

                m++;
                if (m == 60)
                {
                    m = 0;
                    h++;
                }

            }
        }
    }
}

