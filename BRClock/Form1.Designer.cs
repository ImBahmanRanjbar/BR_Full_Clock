namespace BRClock
{
    partial class mForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mForm));
            this.dashpnl = new System.Windows.Forms.Panel();
            this.mainpnl = new System.Windows.Forms.Panel();
            this.elipseControlBahman1 = new BahmanElipse.ElipseControlBahman();
            this.elipseControlBahman2 = new BahmanElipse.ElipseControlBahman();
            this.BtnSetAlarm = new BahmanButton.BahmanButtonControl();
            this.BtnTimer = new BahmanButton.BahmanButtonControl();
            this.BtnSW = new BahmanButton.BahmanButtonControl();
            this.BtnTime = new BahmanButton.BahmanButtonControl();
            this.btnHome = new BahmanButton.BahmanButtonControl();
            this.dashpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashpnl
            // 
            this.dashpnl.BackColor = System.Drawing.Color.Snow;
            this.dashpnl.Controls.Add(this.BtnSetAlarm);
            this.dashpnl.Controls.Add(this.BtnTimer);
            this.dashpnl.Controls.Add(this.BtnSW);
            this.dashpnl.Controls.Add(this.BtnTime);
            this.dashpnl.Controls.Add(this.btnHome);
            this.dashpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashpnl.Location = new System.Drawing.Point(20, 20);
            this.dashpnl.Margin = new System.Windows.Forms.Padding(0);
            this.dashpnl.Name = "dashpnl";
            this.dashpnl.Size = new System.Drawing.Size(200, 507);
            this.dashpnl.TabIndex = 0;
            // 
            // mainpnl
            // 
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(220, 20);
            this.mainpnl.Margin = new System.Windows.Forms.Padding(0);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(761, 507);
            this.mainpnl.TabIndex = 1;
            // 
            // elipseControlBahman1
            // 
            this.elipseControlBahman1.CornerRadius = 25;
            this.elipseControlBahman1.TargetControl = this.dashpnl;
            // 
            // elipseControlBahman2
            // 
            this.elipseControlBahman2.CornerRadius = 25;
            this.elipseControlBahman2.TargetControl = this.mainpnl;
            // 
            // BtnSetAlarm
            // 
            this.BtnSetAlarm.BackColor = System.Drawing.Color.Lavender;
            this.BtnSetAlarm.BackgroundColor = System.Drawing.Color.Lavender;
            this.BtnSetAlarm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.BtnSetAlarm.BorderRadius = 10;
            this.BtnSetAlarm.BorderSize = 0;
            this.BtnSetAlarm.FlatAppearance.BorderSize = 0;
            this.BtnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetAlarm.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 8.25F);
            this.BtnSetAlarm.ForeColor = System.Drawing.Color.Black;
            this.BtnSetAlarm.Image = global::BRClock.Properties.Resources.notifications_active_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.BtnSetAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetAlarm.Location = new System.Drawing.Point(29, 341);
            this.BtnSetAlarm.Name = "BtnSetAlarm";
            this.BtnSetAlarm.Size = new System.Drawing.Size(144, 28);
            this.BtnSetAlarm.TabIndex = 2;
            this.BtnSetAlarm.Text = "SetAlarm";
            this.BtnSetAlarm.TextColor = System.Drawing.Color.Black;
            this.BtnSetAlarm.UseVisualStyleBackColor = false;
            this.BtnSetAlarm.Click += new System.EventHandler(this.BtnSetAlarm_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.Color.Lavender;
            this.BtnTimer.BackgroundColor = System.Drawing.Color.Lavender;
            this.BtnTimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.BtnTimer.BorderRadius = 10;
            this.BtnTimer.BorderSize = 0;
            this.BtnTimer.FlatAppearance.BorderSize = 0;
            this.BtnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTimer.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 8.25F);
            this.BtnTimer.ForeColor = System.Drawing.Color.Black;
            this.BtnTimer.Image = global::BRClock.Properties.Resources.countdown;
            this.BtnTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTimer.Location = new System.Drawing.Point(29, 283);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(144, 28);
            this.BtnTimer.TabIndex = 2;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.TextColor = System.Drawing.Color.Black;
            this.BtnTimer.UseVisualStyleBackColor = false;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // BtnSW
            // 
            this.BtnSW.BackColor = System.Drawing.Color.Lavender;
            this.BtnSW.BackgroundColor = System.Drawing.Color.Lavender;
            this.BtnSW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.BtnSW.BorderRadius = 10;
            this.BtnSW.BorderSize = 0;
            this.BtnSW.FlatAppearance.BorderSize = 0;
            this.BtnSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSW.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 8.25F);
            this.BtnSW.ForeColor = System.Drawing.Color.Black;
            this.BtnSW.Image = global::BRClock.Properties.Resources.stopwatch;
            this.BtnSW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSW.Location = new System.Drawing.Point(29, 231);
            this.BtnSW.Name = "BtnSW";
            this.BtnSW.Size = new System.Drawing.Size(144, 28);
            this.BtnSW.TabIndex = 2;
            this.BtnSW.Text = "StopWatch";
            this.BtnSW.TextColor = System.Drawing.Color.Black;
            this.BtnSW.UseVisualStyleBackColor = false;
            this.BtnSW.Click += new System.EventHandler(this.BtnSW_Click);
            // 
            // BtnTime
            // 
            this.BtnTime.BackColor = System.Drawing.Color.Lavender;
            this.BtnTime.BackgroundColor = System.Drawing.Color.Lavender;
            this.BtnTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.BtnTime.BorderRadius = 10;
            this.BtnTime.BorderSize = 0;
            this.BtnTime.FlatAppearance.BorderSize = 0;
            this.BtnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTime.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 8.25F);
            this.BtnTime.ForeColor = System.Drawing.Color.Black;
            this.BtnTime.Image = global::BRClock.Properties.Resources.time1;
            this.BtnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTime.Location = new System.Drawing.Point(29, 176);
            this.BtnTime.Name = "BtnTime";
            this.BtnTime.Size = new System.Drawing.Size(144, 28);
            this.BtnTime.TabIndex = 2;
            this.BtnTime.Text = "Time";
            this.BtnTime.TextColor = System.Drawing.Color.Black;
            this.BtnTime.UseVisualStyleBackColor = false;
            this.BtnTime.Click += new System.EventHandler(this.bahmanButtonControl1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Lavender;
            this.btnHome.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 1;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::BRClock.Properties.Resources.home_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(29, 118);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 28);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 547);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.dashpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRClock";
            this.Load += new System.EventHandler(this.mForm_Load);
            this.dashpnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashpnl;
        private System.Windows.Forms.Panel mainpnl;
        private BahmanElipse.ElipseControlBahman elipseControlBahman1;
        private BahmanButton.BahmanButtonControl btnHome;
        private BahmanButton.BahmanButtonControl BtnTime;
        private BahmanButton.BahmanButtonControl BtnTimer;
        private BahmanButton.BahmanButtonControl BtnSW;
        private BahmanButton.BahmanButtonControl BtnSetAlarm;
        private BahmanElipse.ElipseControlBahman elipseControlBahman2;
    }
}

