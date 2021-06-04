namespace Payroll
{
    partial class frmHRViewables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHRViewables));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewretired = new System.Windows.Forms.Button();
            this.btnViewinactive = new System.Windows.Forms.Button();
            this.btnViewemp = new System.Windows.Forms.Button();
            this.btnViewpay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnViewretired);
            this.groupBox3.Controls.Add(this.btnViewinactive);
            this.groupBox3.Controls.Add(this.btnViewemp);
            this.groupBox3.Controls.Add(this.btnViewpay);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(41, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 97);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viewable Information";
            // 
            // btnViewretired
            // 
            this.btnViewretired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewretired.ForeColor = System.Drawing.Color.Black;
            this.btnViewretired.Location = new System.Drawing.Point(422, 57);
            this.btnViewretired.Name = "btnViewretired";
            this.btnViewretired.Size = new System.Drawing.Size(247, 29);
            this.btnViewretired.TabIndex = 11;
            this.btnViewretired.Text = "View Retired Employees";
            this.btnViewretired.UseVisualStyleBackColor = false;
            this.btnViewretired.Click += new System.EventHandler(this.btnViewretired_Click);
            // 
            // btnViewinactive
            // 
            this.btnViewinactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewinactive.ForeColor = System.Drawing.Color.Black;
            this.btnViewinactive.Location = new System.Drawing.Point(422, 22);
            this.btnViewinactive.Name = "btnViewinactive";
            this.btnViewinactive.Size = new System.Drawing.Size(247, 29);
            this.btnViewinactive.TabIndex = 10;
            this.btnViewinactive.Text = "View Inactive Employees";
            this.btnViewinactive.UseVisualStyleBackColor = false;
            this.btnViewinactive.Click += new System.EventHandler(this.btnViewinactive_Click);
            // 
            // btnViewemp
            // 
            this.btnViewemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewemp.ForeColor = System.Drawing.Color.Black;
            this.btnViewemp.Location = new System.Drawing.Point(16, 24);
            this.btnViewemp.Name = "btnViewemp";
            this.btnViewemp.Size = new System.Drawing.Size(189, 62);
            this.btnViewemp.TabIndex = 3;
            this.btnViewemp.Text = "View Current Employees";
            this.btnViewemp.UseVisualStyleBackColor = false;
            this.btnViewemp.Click += new System.EventHandler(this.BtnViewemp_Click);
            // 
            // btnViewpay
            // 
            this.btnViewpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewpay.ForeColor = System.Drawing.Color.Black;
            this.btnViewpay.Location = new System.Drawing.Point(220, 22);
            this.btnViewpay.Name = "btnViewpay";
            this.btnViewpay.Size = new System.Drawing.Size(189, 64);
            this.btnViewpay.TabIndex = 9;
            this.btnViewpay.Text = "View Employee Paycheck History";
            this.btnViewpay.UseVisualStyleBackColor = false;
            this.btnViewpay.Click += new System.EventHandler(this.BtnViewpay_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(24, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 477);
            this.panel1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(680, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmHRViewables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHRViewables";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.frmHRViewables_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewemp;
        private System.Windows.Forms.Button btnViewpay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewretired;
        private System.Windows.Forms.Button btnViewinactive;
    }
}