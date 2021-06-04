namespace Payroll
{
    partial class Human_Resource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Human_Resource));
            this.btnX = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubpay = new System.Windows.Forms.Button();
            this.btnEmpinfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpcontrols = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.Current_time = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.Label();
            this.lblHRname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payroll_dbDataSet = new Payroll.payroll_dbDataSet();
            this.payrolldbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDispute = new System.Windows.Forms.Panel();
            this.currentEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.current_EmployeesTableAdapter = new Payroll.payroll_dbDataSetTableAdapters.Current_EmployeesTableAdapter();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Payroll.payroll_dbDataSetTableAdapters.RequestsTableAdapter();
            this.requestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlPaycheck = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrolldbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.Location = new System.Drawing.Point(885, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 14;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSubpay);
            this.panel1.Controls.Add(this.btnEmpinfo);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEmpcontrols);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 598);
            this.panel1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 53);
            this.button2.TabIndex = 23;
            this.button2.Text = "Live Chat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 62);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Solve Dispute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSubpay
            // 
            this.btnSubpay.BackColor = System.Drawing.Color.Black;
            this.btnSubpay.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSubpay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubpay.Location = new System.Drawing.Point(0, 232);
            this.btnSubpay.Name = "btnSubpay";
            this.btnSubpay.Size = new System.Drawing.Size(158, 53);
            this.btnSubpay.TabIndex = 20;
            this.btnSubpay.Text = "Submit Employee Paychecks";
            this.btnSubpay.UseVisualStyleBackColor = false;
            this.btnSubpay.Click += new System.EventHandler(this.btnSubpay_Click);
            // 
            // btnEmpinfo
            // 
            this.btnEmpinfo.BackColor = System.Drawing.Color.Black;
            this.btnEmpinfo.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEmpinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpinfo.Location = new System.Drawing.Point(0, 179);
            this.btnEmpinfo.Name = "btnEmpinfo";
            this.btnEmpinfo.Size = new System.Drawing.Size(158, 53);
            this.btnEmpinfo.TabIndex = 19;
            this.btnEmpinfo.Text = "View Employee Information";
            this.btnEmpinfo.UseVisualStyleBackColor = false;
            this.btnEmpinfo.Click += new System.EventHandler(this.btnEmpinfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(0, 533);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 62);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpcontrols
            // 
            this.btnEmpcontrols.BackColor = System.Drawing.Color.Black;
            this.btnEmpcontrols.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEmpcontrols.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpcontrols.Location = new System.Drawing.Point(0, 126);
            this.btnEmpcontrols.Name = "btnEmpcontrols";
            this.btnEmpcontrols.Size = new System.Drawing.Size(158, 53);
            this.btnEmpcontrols.TabIndex = 2;
            this.btnEmpcontrols.Text = "Employee Controls";
            this.btnEmpcontrols.UseVisualStyleBackColor = false;
            this.btnEmpcontrols.Click += new System.EventHandler(this.btnEmpcontrols_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.Current_time);
            this.pnlTop.Controls.Add(this.Times);
            this.pnlTop.Controls.Add(this.lblHRname);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(921, 43);
            this.pnlTop.TabIndex = 16;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.Location = new System.Drawing.Point(846, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Current_time
            // 
            this.Current_time.AutoSize = true;
            this.Current_time.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Current_time.Location = new System.Drawing.Point(639, 12);
            this.Current_time.Name = "Current_time";
            this.Current_time.Size = new System.Drawing.Size(51, 21);
            this.Current_time.TabIndex = 19;
            this.Current_time.Text = "Date:";
            // 
            // Times
            // 
            this.Times.AutoSize = true;
            this.Times.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Times.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Times.Location = new System.Drawing.Point(696, 12);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(58, 21);
            this.Times.TabIndex = 18;
            this.Times.Text = "00 : 00";
            // 
            // lblHRname
            // 
            this.lblHRname.AutoSize = true;
            this.lblHRname.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHRname.Location = new System.Drawing.Point(385, 9);
            this.lblHRname.Name = "lblHRname";
            this.lblHRname.Size = new System.Drawing.Size(91, 21);
            this.lblHRname.TabIndex = 17;
            this.lblHRname.Text = "HR\'s name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome to KOCH Payroll system";
            // 
            // payroll_dbDataSet
            // 
            this.payroll_dbDataSet.DataSetName = "payroll_dbDataSet";
            this.payroll_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrolldbDataSetBindingSource
            // 
            this.payrolldbDataSetBindingSource.DataSource = this.payroll_dbDataSet;
            this.payrolldbDataSetBindingSource.Position = 0;
            // 
            // pnlDispute
            // 
            this.pnlDispute.BackColor = System.Drawing.Color.Transparent;
            this.pnlDispute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDispute.Location = new System.Drawing.Point(160, 43);
            this.pnlDispute.Name = "pnlDispute";
            this.pnlDispute.Size = new System.Drawing.Size(761, 598);
            this.pnlDispute.TabIndex = 17;
            // 
            // currentEmployeesBindingSource
            // 
            this.currentEmployeesBindingSource.DataMember = "Current_Employees";
            this.currentEmployeesBindingSource.DataSource = this.payrolldbDataSetBindingSource;
            // 
            // current_EmployeesTableAdapter
            // 
            this.current_EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.payrolldbDataSetBindingSource;
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
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployee.Location = new System.Drawing.Point(160, 43);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(761, 598);
            this.pnlEmployee.TabIndex = 22;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Location = new System.Drawing.Point(160, 43);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(761, 598);
            this.pnlInfo.TabIndex = 15;
            // 
            // pnlPaycheck
            // 
            this.pnlPaycheck.BackColor = System.Drawing.Color.Transparent;
            this.pnlPaycheck.Location = new System.Drawing.Point(160, 43);
            this.pnlPaycheck.Name = "pnlPaycheck";
            this.pnlPaycheck.Size = new System.Drawing.Size(761, 598);
            this.pnlPaycheck.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(160, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 598);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // Human_Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDispute);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.pnlPaycheck);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Human_Resource";
            this.Text = "Human_Resource";
            this.Load += new System.EventHandler(this.Human_Resource_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Human_Resource_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Human_Resource_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payroll_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrolldbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHRname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpcontrols;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource payrolldbDataSetBindingSource;
        private payroll_dbDataSet payroll_dbDataSet;
        private System.Windows.Forms.Panel pnlDispute;
        private System.Windows.Forms.Button btnEmpinfo;
        private System.Windows.Forms.Button btnSubpay;
        private System.Windows.Forms.BindingSource currentEmployeesBindingSource;
        private payroll_dbDataSetTableAdapters.Current_EmployeesTableAdapter current_EmployeesTableAdapter;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private payroll_dbDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solvedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource requestsBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlPaycheck;
        private System.Windows.Forms.Label Times;
        private System.Windows.Forms.Label Current_time;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}