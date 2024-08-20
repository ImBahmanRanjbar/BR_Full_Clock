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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            richsec.Focus();
        }


        int s, m, h;
        int t1 = 0;
        int t2 = 0;

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int s = 0, m = 0, h = 0;
            richours.Text = $"{h.ToString("00")}";
            richmin.Text = $"{m.ToString("00")}";
            richsec.Text = $"{s.ToString("00")}";
            BtnStart.Text = "Start";
            richsec.ReadOnly = false;
            richmin.ReadOnly = false;
            richours.ReadOnly = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            s = int.Parse(richsec.Text);
            m = int.Parse(richmin.Text);
            h = int.Parse(richours.Text);
            richsec.ReadOnly = true;
            richmin.ReadOnly = true;
            richours.ReadOnly = true;
            BtnStart.Focus();
            if (BtnStart.Text == "Start")
            {
                
                BtnStart.Text = "Pause";
                timer1.Start();
            }
            else
            {
                BtnStart.Text = "Start";
              
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s >= 0)
            {

                s--;
                if (s==01)
                {
                    t1 = s;
                }
                

                richours.Text = $"{h.ToString("00")}";
                richmin.Text = $"{m.ToString("00")}";
                richsec.Text = $"{s.ToString("00")}";
            }
            if (s == -1)
            {
                s = 0;
                richours.Text = $"{h.ToString("00")}";
                richmin.Text = $"{m.ToString("00")}";
                richsec.Text = $"{s.ToString("00")}";
            }

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
            if (s <= 0)
            {
                if (m > 0 || h > 0)
                {
                    if (m == 0)
                    {
                        if (h >= 0)
                        {
                            h--;
                            m = 60;
                            if (h < 0)
                            {
                                h = 0;
                                
                                if (h == 0 && m == 0 && s == 0)
                                {
                                    richours.Text = $"{h.ToString("00")}";
                                    richmin.Text = $"{m.ToString("00")}";
                                    richsec.Text = $"{s.ToString("00")}";
                                    timer1.Stop();
                                   

                                }

                            }
                        }

                    }
                    m--;
                    s = 59;
                    timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                    richours.Text = $"{h.ToString("00")}";
                    richmin.Text = $"{m.ToString("00")}";
                    richsec.Text = $"{s.ToString("00")}";
                    
                    if (m < 0)
                    {
                        m = 0;
                    }
                    if (s < 0)
                    {
                        s = 0;

                    }


                    if (h == 0 && m == 0 && s == 0)
                    {
                        timer1.Stop();
                        richours.Text = $"{h.ToString("00")}";
                        richmin.Text = $"{m.ToString("00")}";
                        richsec.Text = $"{s.ToString("00")}";
                        System.Media.SoundPlayer p = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                       p.Play();


                    }
                }
                timer1.Stop();

                System.Media.SoundPlayer p3 = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                p3.Play();
                if (h == 0 && m == 0 && s == 0)
                {
                    if (BtnStart.Text == "Start")
                    {
                        BtnStart.Text = "Pause";
                    
                        timer1.Start();
                    }
                    else
                    {
                        BtnStart.Text = "Start";
                        
                        timer1.Stop();
                        System.Media.SoundPlayer p2 = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                        p2.Play();
                    }

                }
                timer1.Stop();
                System.Media.SoundPlayer p1 = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                p1.Play();

                richsec.ReadOnly = false;
                richmin.ReadOnly = false;
                richours.ReadOnly = false;
                BtnStart.Focus();
            }
        }
    }
}

