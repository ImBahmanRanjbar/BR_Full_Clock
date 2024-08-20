namespace BRClock
{
    partial class FormStopWatch
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
            this.components = new System.ComponentModel.Container();
            this.LblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new BahmanButton.BahmanButtonControl();
            this.BtnPlay = new BahmanButton.BahmanButtonControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold);
            this.LblTimer.Location = new System.Drawing.Point(56, 139);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(308, 89);
            this.LblTimer.TabIndex = 0;
            this.LblTimer.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.LblTimer);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 228);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.BtnStop);
            this.panel2.Controls.Add(this.BtnPlay);
            this.panel2.Location = new System.Drawing.Point(15, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 97);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 245);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnStop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStop.BorderRadius = 45;
            this.BtnStop.BorderSize = 1;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Image = global::BRClock.Properties.Resources.stop;
            this.BtnStop.Location = new System.Drawing.Point(116, 0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(93, 94);
            this.BtnStop.TabIndex = 0;
            this.BtnStop.Tag = "Stop";
            this.BtnStop.TextColor = System.Drawing.Color.White;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnPlay.BorderRadius = 45;
            this.BtnPlay.BorderSize = 1;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnPlay.Image = global::BRClock.Properties.Resources.play;
            this.BtnPlay.Location = new System.Drawing.Point(215, 1);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(93, 94);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Tag = "Play";
            this.BtnPlay.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FormStopWatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStopWatch";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FormStopWatch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BahmanButton.BahmanButtonControl BtnPlay;
        private BahmanButton.BahmanButtonControl BtnStop;
        private System.Windows.Forms.Timer timer;
    }
}