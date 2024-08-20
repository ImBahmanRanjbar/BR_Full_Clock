namespace BRClock
{
    partial class FormSetAlarm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new BahmanButton.BahmanButtonControl();
            this.BtnStart = new BahmanButton.BahmanButtonControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Aquamarine;
            this.dateTimePicker1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(116, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(116, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 92);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.BtnStop);
            this.panel3.Controls.Add(this.BtnStart);
            this.panel3.Location = new System.Drawing.Point(116, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 100);
            this.panel3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStop.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnStop.BorderRadius = 0;
            this.BtnStop.BorderSize = 0;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Location = new System.Drawing.Point(229, 20);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(150, 40);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.TextColor = System.Drawing.Color.White;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click_1);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStart.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnStart.BorderRadius = 0;
            this.BtnStart.BorderSize = 0;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(31, 20);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(150, 40);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.TextColor = System.Drawing.Color.White;
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FormSetAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(669, 408);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetAlarm";
            this.Text = "FormSetAlarm";
            this.Load += new System.EventHandler(this.FormSetAlarm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BahmanButton.BahmanButtonControl BtnStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private BahmanButton.BahmanButtonControl BtnStop;
        private System.Windows.Forms.Timer timer1;
    }
}