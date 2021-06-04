namespace Payroll
{
    partial class frmClockInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClockInOut));
            this.gbCurP = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClockout = new System.Windows.Forms.Button();
            this.btnClockin = new System.Windows.Forms.Button();
            this.gbLasP = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbTimeworked = new System.Windows.Forms.GroupBox();
            this.gbCurP.SuspendLayout();
            this.gbLasP.SuspendLayout();
            this.gbTimeworked.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCurP
            // 
            this.gbCurP.BackColor = System.Drawing.Color.Transparent;
            this.gbCurP.Controls.Add(this.button1);
            this.gbCurP.Controls.Add(this.btnClockout);
            this.gbCurP.Controls.Add(this.btnClockin);
            this.gbCurP.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCurP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCurP.Location = new System.Drawing.Point(95, 254);
            this.gbCurP.Name = "gbCurP";
            this.gbCurP.Size = new System.Drawing.Size(573, 164);
            this.gbCurP.TabIndex = 18;
            this.gbCurP.TabStop = false;
            this.gbCurP.Text = "Clock In and Out Options";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(204, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clock Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnClockout
            // 
            this.btnClockout.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClockout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockout.Location = new System.Drawing.Point(400, 59);
            this.btnClockout.Name = "btnClockout";
            this.btnClockout.Size = new System.Drawing.Size(154, 60);
            this.btnClockout.TabIndex = 19;
            this.btnClockout.Text = "Clock Out";
            this.btnClockout.UseVisualStyleBackColor = true;
            this.btnClockout.Click += new System.EventHandler(this.btnClockout_Click);
            // 
            // btnClockin
            // 
            this.btnClockin.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClockin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockin.Location = new System.Drawing.Point(30, 59);
            this.btnClockin.Name = "btnClockin";
            this.btnClockin.Size = new System.Drawing.Size(145, 57);
            this.btnClockin.TabIndex = 18;
            this.btnClockin.Text = "Clock In";
            this.btnClockin.UseVisualStyleBackColor = true;
            this.btnClockin.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // gbLasP
            // 
            this.gbLasP.BackColor = System.Drawing.Color.Transparent;
            this.gbLasP.Controls.Add(this.button6);
            this.gbLasP.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLasP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLasP.Location = new System.Drawing.Point(95, 447);
            this.gbLasP.Name = "gbLasP";
            this.gbLasP.Size = new System.Drawing.Size(573, 131);
            this.gbLasP.TabIndex = 17;
            this.gbLasP.TabStop = false;
            this.gbLasP.Text = "Submit Bi-weekly Timesheet";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(55, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(442, 72);
            this.button6.TabIndex = 9;
            this.button6.Text = "Submit Timesheet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(157, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "00 : 00 : 00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(237, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 67);
            this.label2.TabIndex = 20;
            this.label2.Text = "00 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gbTimeworked
            // 
            this.gbTimeworked.BackColor = System.Drawing.Color.Transparent;
            this.gbTimeworked.Controls.Add(this.label1);
            this.gbTimeworked.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTimeworked.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTimeworked.Location = new System.Drawing.Point(95, 21);
            this.gbTimeworked.Name = "gbTimeworked";
            this.gbTimeworked.Size = new System.Drawing.Size(266, 97);
            this.gbTimeworked.TabIndex = 22;
            this.gbTimeworked.TabStop = false;
            this.gbTimeworked.Text = "Time Worked This Pay Period";
            // 
            // frmClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.gbTimeworked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbCurP);
            this.Controls.Add(this.gbLasP);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClockInOut";
            this.Text = "Search_history";
            this.Load += new System.EventHandler(this.frmClockInOut_Load);
            this.gbCurP.ResumeLayout(false);
            this.gbLasP.ResumeLayout(false);
            this.gbTimeworked.ResumeLayout(false);
            this.gbTimeworked.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurP;
        private System.Windows.Forms.GroupBox gbLasP;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClockin;
        private System.Windows.Forms.Button btnClockout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbTimeworked;
    }
}