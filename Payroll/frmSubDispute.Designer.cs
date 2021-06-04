namespace Payroll
{
    partial class frmSubDispute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubDispute));
            this.gbLasP = new System.Windows.Forms.GroupBox();
            this.btnSubDispute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDispute = new System.Windows.Forms.TextBox();
            this.gbLasP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLasP
            // 
            this.gbLasP.BackColor = System.Drawing.Color.Transparent;
            this.gbLasP.Controls.Add(this.btnSubDispute);
            this.gbLasP.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLasP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLasP.Location = new System.Drawing.Point(96, 371);
            this.gbLasP.Name = "gbLasP";
            this.gbLasP.Size = new System.Drawing.Size(573, 131);
            this.gbLasP.TabIndex = 17;
            this.gbLasP.TabStop = false;
            this.gbLasP.Text = "Send Dispute to HR Department";
            // 
            // btnSubDispute
            // 
            this.btnSubDispute.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSubDispute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubDispute.Location = new System.Drawing.Point(55, 39);
            this.btnSubDispute.Name = "btnSubDispute";
            this.btnSubDispute.Size = new System.Drawing.Size(442, 72);
            this.btnSubDispute.TabIndex = 9;
            this.btnSubDispute.Text = "Submit Dispute";
            this.btnSubDispute.UseVisualStyleBackColor = true;
            this.btnSubDispute.Click += new System.EventHandler(this.BtnSubDispute_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbDispute);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(95, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 308);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please type your dispute in the box below";
            // 
            // tbDispute
            // 
            this.tbDispute.Location = new System.Drawing.Point(56, 38);
            this.tbDispute.Multiline = true;
            this.tbDispute.Name = "tbDispute";
            this.tbDispute.Size = new System.Drawing.Size(442, 245);
            this.tbDispute.TabIndex = 0;
            // 
            // frmSubDispute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLasP);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubDispute";
            this.Text = "Search_history";
            this.Load += new System.EventHandler(this.frmSubDispute_Load);
            this.gbLasP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbLasP;
        private System.Windows.Forms.Button btnSubDispute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDispute;
    }
}