namespace Payroll
{
    partial class chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chart));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbSendm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLivechat = new System.Windows.Forms.GroupBox();
            this.gbSendm.SuspendLayout();
            this.gbLivechat.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(634, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(706, 324);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(612, 83);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // gbSendm
            // 
            this.gbSendm.BackColor = System.Drawing.Color.Transparent;
            this.gbSendm.Controls.Add(this.label1);
            this.gbSendm.Controls.Add(this.textBox2);
            this.gbSendm.Controls.Add(this.button1);
            this.gbSendm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSendm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSendm.Location = new System.Drawing.Point(12, 402);
            this.gbSendm.Name = "gbSendm";
            this.gbSendm.Size = new System.Drawing.Size(739, 155);
            this.gbSendm.TabIndex = 13;
            this.gbSendm.TabStop = false;
            this.gbSendm.Text = "Send Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "*NOTE: To begin a new line, press the down arrow key";
            // 
            // gbLivechat
            // 
            this.gbLivechat.BackColor = System.Drawing.Color.Transparent;
            this.gbLivechat.Controls.Add(this.textBox1);
            this.gbLivechat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLivechat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLivechat.Location = new System.Drawing.Point(12, 12);
            this.gbLivechat.Name = "gbLivechat";
            this.gbLivechat.Size = new System.Drawing.Size(739, 375);
            this.gbLivechat.TabIndex = 14;
            this.gbLivechat.TabStop = false;
            this.gbLivechat.Text = "Live Chat Window";
            // 
            // chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 598);
            this.Controls.Add(this.gbSendm);
            this.Controls.Add(this.gbLivechat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chart";
            this.Text = "chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.gbSendm.ResumeLayout(false);
            this.gbSendm.PerformLayout();
            this.gbLivechat.ResumeLayout(false);
            this.gbLivechat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbSendm;
        private System.Windows.Forms.GroupBox gbLivechat;
        private System.Windows.Forms.Label label1;
    }
}