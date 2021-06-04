namespace Payroll
{
    partial class frmPaymentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentInfo));
            this.gbCurP = new System.Windows.Forms.GroupBox();
            this.lblPaychangecur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEarnedchangecur = new System.Windows.Forms.Label();
            this.lblHworked = new System.Windows.Forms.Label();
            this.lblEarned = new System.Windows.Forms.Label();
            this.lblHourschangecur = new System.Windows.Forms.Label();
            this.gbLasP = new System.Windows.Forms.GroupBox();
            this.lblPaychangepas = new System.Windows.Forms.Label();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.lblEarnedchangepas = new System.Windows.Forms.Label();
            this.lblHworkedpast = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEarnedpast = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblPaiddate = new System.Windows.Forms.Label();
            this.lblHourschangepas = new System.Windows.Forms.Label();
            this.lblDatechangepas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCurP.SuspendLayout();
            this.gbLasP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCurP
            // 
            this.gbCurP.BackColor = System.Drawing.Color.Transparent;
            this.gbCurP.Controls.Add(this.lblPaychangecur);
            this.gbCurP.Controls.Add(this.label2);
            this.gbCurP.Controls.Add(this.lblEarnedchangecur);
            this.gbCurP.Controls.Add(this.lblHworked);
            this.gbCurP.Controls.Add(this.lblEarned);
            this.gbCurP.Controls.Add(this.lblHourschangecur);
            this.gbCurP.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCurP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCurP.Location = new System.Drawing.Point(128, 17);
            this.gbCurP.Name = "gbCurP";
            this.gbCurP.Size = new System.Drawing.Size(507, 231);
            this.gbCurP.TabIndex = 18;
            this.gbCurP.TabStop = false;
            this.gbCurP.Text = "Current Paycheck";
            // 
            // lblPaychangecur
            // 
            this.lblPaychangecur.AutoSize = true;
            this.lblPaychangecur.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaychangecur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPaychangecur.Location = new System.Drawing.Point(307, 72);
            this.lblPaychangecur.Name = "lblPaychangecur";
            this.lblPaychangecur.Size = new System.Drawing.Size(50, 21);
            this.lblPaychangecur.TabIndex = 17;
            this.lblPaychangecur.Text = "$$.$$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Pay Rate:";
            // 
            // lblEarnedchangecur
            // 
            this.lblEarnedchangecur.AutoSize = true;
            this.lblEarnedchangecur.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnedchangecur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEarnedchangecur.Location = new System.Drawing.Point(307, 139);
            this.lblEarnedchangecur.Name = "lblEarnedchangecur";
            this.lblEarnedchangecur.Size = new System.Drawing.Size(59, 21);
            this.lblEarnedchangecur.TabIndex = 15;
            this.lblEarnedchangecur.Text = "$$$.$$";
            // 
            // lblHworked
            // 
            this.lblHworked.AutoSize = true;
            this.lblHworked.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHworked.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHworked.Location = new System.Drawing.Point(68, 103);
            this.lblHworked.Name = "lblHworked";
            this.lblHworked.Size = new System.Drawing.Size(119, 21);
            this.lblHworked.TabIndex = 14;
            this.lblHworked.Text = "Hours worked:";
            // 
            // lblEarned
            // 
            this.lblEarned.AutoSize = true;
            this.lblEarned.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarned.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEarned.Location = new System.Drawing.Point(68, 139);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(137, 21);
            this.lblEarned.TabIndex = 12;
            this.lblEarned.Text = "Amount earned:";
            // 
            // lblHourschangecur
            // 
            this.lblHourschangecur.AutoSize = true;
            this.lblHourschangecur.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourschangecur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHourschangecur.Location = new System.Drawing.Point(307, 103);
            this.lblHourschangecur.Name = "lblHourschangecur";
            this.lblHourschangecur.Size = new System.Drawing.Size(50, 21);
            this.lblHourschangecur.TabIndex = 13;
            this.lblHourschangecur.Text = "00.00";
            // 
            // gbLasP
            // 
            this.gbLasP.BackColor = System.Drawing.Color.Transparent;
            this.gbLasP.Controls.Add(this.lblPaychangepas);
            this.gbLasP.Controls.Add(this.lblPayrate);
            this.gbLasP.Controls.Add(this.lblEarnedchangepas);
            this.gbLasP.Controls.Add(this.lblHworkedpast);
            this.gbLasP.Controls.Add(this.dateTimePicker1);
            this.gbLasP.Controls.Add(this.lblEarnedpast);
            this.gbLasP.Controls.Add(this.button6);
            this.gbLasP.Controls.Add(this.lblPaiddate);
            this.gbLasP.Controls.Add(this.lblHourschangepas);
            this.gbLasP.Controls.Add(this.lblDatechangepas);
            this.gbLasP.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLasP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLasP.Location = new System.Drawing.Point(128, 248);
            this.gbLasP.Name = "gbLasP";
            this.gbLasP.Size = new System.Drawing.Size(507, 325);
            this.gbLasP.TabIndex = 17;
            this.gbLasP.TabStop = false;
            this.gbLasP.Text = "Last Paycheck";
            // 
            // lblPaychangepas
            // 
            this.lblPaychangepas.AutoSize = true;
            this.lblPaychangepas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaychangepas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPaychangepas.Location = new System.Drawing.Point(302, 153);
            this.lblPaychangepas.Name = "lblPaychangepas";
            this.lblPaychangepas.Size = new System.Drawing.Size(50, 21);
            this.lblPaychangepas.TabIndex = 13;
            this.lblPaychangepas.Text = "$$.$$";
            // 
            // lblPayrate
            // 
            this.lblPayrate.AutoSize = true;
            this.lblPayrate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPayrate.Location = new System.Drawing.Point(63, 151);
            this.lblPayrate.Name = "lblPayrate";
            this.lblPayrate.Size = new System.Drawing.Size(82, 21);
            this.lblPayrate.TabIndex = 12;
            this.lblPayrate.Text = "Pay Rate:";
            // 
            // lblEarnedchangepas
            // 
            this.lblEarnedchangepas.AutoSize = true;
            this.lblEarnedchangepas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnedchangepas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEarnedchangepas.Location = new System.Drawing.Point(302, 78);
            this.lblEarnedchangepas.Name = "lblEarnedchangepas";
            this.lblEarnedchangepas.Size = new System.Drawing.Size(59, 21);
            this.lblEarnedchangepas.TabIndex = 11;
            this.lblEarnedchangepas.Text = "$$$.$$";
            // 
            // lblHworkedpast
            // 
            this.lblHworkedpast.AutoSize = true;
            this.lblHworkedpast.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHworkedpast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHworkedpast.Location = new System.Drawing.Point(63, 42);
            this.lblHworkedpast.Name = "lblHworkedpast";
            this.lblHworkedpast.Size = new System.Drawing.Size(119, 21);
            this.lblHworkedpast.TabIndex = 10;
            this.lblHworkedpast.Text = "Hours worked:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblEarnedpast
            // 
            this.lblEarnedpast.AutoSize = true;
            this.lblEarnedpast.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnedpast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEarnedpast.Location = new System.Drawing.Point(63, 78);
            this.lblEarnedpast.Name = "lblEarnedpast";
            this.lblEarnedpast.Size = new System.Drawing.Size(137, 21);
            this.lblEarnedpast.TabIndex = 4;
            this.lblEarnedpast.Text = "Amount earned:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(178, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 31);
            this.button6.TabIndex = 9;
            this.button6.Text = "Seach Now";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblPaiddate
            // 
            this.lblPaiddate.AutoSize = true;
            this.lblPaiddate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaiddate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPaiddate.Location = new System.Drawing.Point(63, 114);
            this.lblPaiddate.Name = "lblPaiddate";
            this.lblPaiddate.Size = new System.Drawing.Size(108, 21);
            this.lblPaiddate.TabIndex = 6;
            this.lblPaiddate.Text = "Submit Date:";
            // 
            // lblHourschangepas
            // 
            this.lblHourschangepas.AutoSize = true;
            this.lblHourschangepas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourschangepas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHourschangepas.Location = new System.Drawing.Point(302, 42);
            this.lblHourschangepas.Name = "lblHourschangepas";
            this.lblHourschangepas.Size = new System.Drawing.Size(50, 21);
            this.lblHourschangepas.TabIndex = 5;
            this.lblHourschangepas.Text = "00.00";
            // 
            // lblDatechangepas
            // 
            this.lblDatechangepas.AutoSize = true;
            this.lblDatechangepas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatechangepas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatechangepas.Location = new System.Drawing.Point(302, 118);
            this.lblDatechangepas.Name = "lblDatechangepas";
            this.lblDatechangepas.Size = new System.Drawing.Size(78, 21);
            this.lblDatechangepas.TabIndex = 7;
            this.lblDatechangepas.Text = "00/00/00";
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
            // frmPaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.gbCurP);
            this.Controls.Add(this.gbLasP);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentInfo";
            this.Text = "Search_history";
            this.Load += new System.EventHandler(this.frmPaymentInfo_Load);
            this.gbCurP.ResumeLayout(false);
            this.gbCurP.PerformLayout();
            this.gbLasP.ResumeLayout(false);
            this.gbLasP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurP;
        private System.Windows.Forms.GroupBox gbLasP;
        private System.Windows.Forms.Label lblPaychangepas;
        private System.Windows.Forms.Label lblPayrate;
        private System.Windows.Forms.Label lblEarnedchangepas;
        private System.Windows.Forms.Label lblHworkedpast;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEarnedpast;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblPaiddate;
        private System.Windows.Forms.Label lblHourschangepas;
        private System.Windows.Forms.Label lblDatechangepas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEarnedchangecur;
        private System.Windows.Forms.Label lblHworked;
        private System.Windows.Forms.Label lblEarned;
        private System.Windows.Forms.Label lblHourschangecur;
        private System.Windows.Forms.Label lblPaychangecur;
        private System.Windows.Forms.Label label2;
    }
}