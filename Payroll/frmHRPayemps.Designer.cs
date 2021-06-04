namespace Payroll
{
    partial class frmHRPayemps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHRPayemps));
            this.gbSubPay = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPayemp = new System.Windows.Forms.Button();
            this.gbSubPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSubPay
            // 
            this.gbSubPay.BackColor = System.Drawing.Color.Transparent;
            this.gbSubPay.Controls.Add(this.textBox2);
            this.gbSubPay.Controls.Add(this.label2);
            this.gbSubPay.Controls.Add(this.label1);
            this.gbSubPay.Controls.Add(this.textBox1);
            this.gbSubPay.Controls.Add(this.btnPayemp);
            this.gbSubPay.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSubPay.Location = new System.Drawing.Point(137, 12);
            this.gbSubPay.Name = "gbSubPay";
            this.gbSubPay.Size = new System.Drawing.Size(510, 326);
            this.gbSubPay.TabIndex = 12;
            this.gbSubPay.TabStop = false;
            this.gbSubPay.Text = "Submit Payments";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 27);
            this.textBox1.TabIndex = 4;
            // 
            // btnPayemp
            // 
            this.btnPayemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPayemp.ForeColor = System.Drawing.Color.Black;
            this.btnPayemp.Location = new System.Drawing.Point(61, 257);
            this.btnPayemp.Name = "btnPayemp";
            this.btnPayemp.Size = new System.Drawing.Size(388, 33);
            this.btnPayemp.TabIndex = 3;
            this.btnPayemp.Text = "Pay Employee (Print Check)";
            this.btnPayemp.UseVisualStyleBackColor = false;
            this.btnPayemp.Click += new System.EventHandler(this.btnPayemp_Click);
            // 
            // frmHRPayemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 598);
            this.Controls.Add(this.gbSubPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHRPayemps";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.FrmHRPayemps_Load);
            this.gbSubPay.ResumeLayout(false);
            this.gbSubPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSubPay;
        private System.Windows.Forms.Button btnPayemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}