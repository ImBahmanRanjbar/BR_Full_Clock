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
    public partial class mForm : Form
    {
        public mForm()
        {
            InitializeComponent();
        }
        public void LoadFmmRS(object Form)
        {
            if (this.mainpnl.Controls.Count > 0)
                this.mainpnl.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpnl.Controls.Add(f);
            this.mainpnl.Tag = f;
            f.Show();
        }

        private void mForm_Load(object sender, EventArgs e)
        {
            LoadFmmRS(new Form0());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void BnTime_Click(object sender, EventArgs e)
        {
            LoadFmmRS(new FormTime());




        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            btnHome.BorderSize = 1;
            BtnTimer.BorderSize = 0;
            BtnTime.BorderSize = 0;
            BtnSW.BorderSize = 0;
            BtnSetAlarm.BorderSize = 0;
            LoadFmmRS(new Form0());
        }

        private void bahmanButtonControl1_Click(object sender, EventArgs e)
        {
            BtnTime.BorderSize = 1;
            BtnTimer.BorderSize = 0;
            btnHome.BorderSize = 0;
            BtnSW.BorderSize = 0;
            BtnSetAlarm.BorderSize = 0;
            LoadFmmRS(new FormTime());


        }

        
        private void BtnSW_Click(object sender, EventArgs e)
        {
            BtnSW.BorderSize = 1;
            BtnTimer.BorderSize = 0;
            BtnTime.BorderSize = 0;
            btnHome.BorderSize = 0;
            BtnSetAlarm.BorderSize = 0;
            LoadFmmRS(new FormStopWatch());
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            BtnTimer.BorderSize = 1;
            BtnSW.BorderSize =0 ;
            BtnTime.BorderSize = 0;
            btnHome.BorderSize = 0;
            BtnSetAlarm.BorderSize = 0;
            LoadFmmRS(new FormTimer());
        }

        private void BtnSetAlarm_Click(object sender, EventArgs e)
        {
            BtnSetAlarm.BorderSize = 1;
            BtnTimer.BorderSize = 0;
            BtnSW.BorderSize = 0;
            BtnTime.BorderSize = 0;
            btnHome.BorderSize = 0;
            LoadFmmRS(new FormSetAlarm());
        }
    }
}
