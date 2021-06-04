namespace Payroll
{
    partial class frmHRDispute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHRDispute));
            this.gbDisputes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSlvdispute = new System.Windows.Forms.Button();
            this.btnClmdispute = new System.Windows.Forms.Button();
            this.payroll_dbDataSet = new Payroll.payroll_dbDataSet();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Payroll.payroll_dbDataSetTableAdapters.RequestsTableAdapter();
            this.requestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbSolve = new System.Windows.Forms.CheckBox();
            this.gbDisputes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDisputes
            // 
            this.gbDisputes.BackColor = System.Drawing.Color.Transparent;
            this.gbDisputes.Controls.Add(this.label1);
            this.gbDisputes.Controls.Add(this.textBox1);
            this.gbDisputes.Controls.Add(this.dataGridView1);
            this.gbDisputes.Controls.Add(this.btnSlvdispute);
            this.gbDisputes.Controls.Add(this.btnClmdispute);
            this.gbDisputes.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisputes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDisputes.Location = new System.Drawing.Point(27, 35);
            this.gbDisputes.Name = "gbDisputes";
            this.gbDisputes.Size = new System.Drawing.Size(707, 476);
            this.gbDisputes.TabIndex = 15;
            this.gbDisputes.TabStop = false;
            this.gbDisputes.Text = "Dispute Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter solution here: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 376);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 83);
            this.textBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 313);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnSlvdispute
            // 
            this.btnSlvdispute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSlvdispute.ForeColor = System.Drawing.Color.Black;
            this.btnSlvdispute.Location = new System.Drawing.Point(498, 427);
            this.btnSlvdispute.Name = "btnSlvdispute";
            this.btnSlvdispute.Size = new System.Drawing.Size(193, 33);
            this.btnSlvdispute.TabIndex = 13;
            this.btnSlvdispute.Text = "Solve Dispute";
            this.btnSlvdispute.UseVisualStyleBackColor = false;
            this.btnSlvdispute.Click += new System.EventHandler(this.BtnSlvdispute_Click);
            // 
            // btnClmdispute
            // 
            this.btnClmdispute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClmdispute.ForeColor = System.Drawing.Color.Black;
            this.btnClmdispute.Location = new System.Drawing.Point(498, 376);
            this.btnClmdispute.Name = "btnClmdispute";
            this.btnClmdispute.Size = new System.Drawing.Size(193, 33);
            this.btnClmdispute.TabIndex = 11;
            this.btnClmdispute.Text = "Claim Dispute";
            this.btnClmdispute.UseVisualStyleBackColor = false;
            this.btnClmdispute.Click += new System.EventHandler(this.BtnClmdispute_Click);
            // 
            // payroll_dbDataSet
            // 
            this.payroll_dbDataSet.DataSetName = "payroll_dbDataSet";
            this.payroll_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.payroll_dbDataSet;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // requestsBindingSource1
            // 
            this.requestsBindingSource1.DataMember = "Requests";
            this.requestsBindingSource1.DataSource = this.payroll_dbDataSet;
            // 
            // cbSolve
            // 
            this.cbSolve.AutoSize = true;
            this.cbSolve.BackColor = System.Drawing.Color.Transparent;
            this.cbSolve.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSolve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSolve.Location = new System.Drawing.Point(172, 535);
            this.cbSolve.Name = "cbSolve";
            this.cbSolve.Size = new System.Drawing.Size(410, 28);
            this.cbSolve.TabIndex = 16;
            this.cbSolve.Text = "Show Solved / Unsolved Claims";
            this.cbSolve.UseVisualStyleBackColor = false;
            this.cbSolve.CheckedChanged += new System.EventHandler(this.cbSolve_CheckedChanged);
            // 
            // frmHRDispute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 598);
            this.Controls.Add(this.cbSolve);
            this.Controls.Add(this.gbDisputes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHRDispute";
            this.Text = "frmHRDispute";
            this.Load += new System.EventHandler(this.FrmHRDispute_Load);
            this.gbDisputes.ResumeLayout(false);
            this.gbDisputes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDisputes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSlvdispute;
        private System.Windows.Forms.Button btnClmdispute;
        private payroll_dbDataSet payroll_dbDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private payroll_dbDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.BindingSource requestsBindingSource1;
        private System.Windows.Forms.CheckBox cbSolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}