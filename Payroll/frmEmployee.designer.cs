namespace Payroll
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubDispute = new System.Windows.Forms.Button();
            this.btnSearchOthr = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClockio = new System.Windows.Forms.Button();
            this.btnPayInfo = new System.Windows.Forms.Button();
            this.btnPersInfo = new System.Windows.Forms.Button();
            this.btnBenefits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.lblEmp = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.Label();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.Current_time = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlBenefits = new System.Windows.Forms.Panel();
            this.pnlPersonInfo = new System.Windows.Forms.Panel();
            this.pnlPaymentInfo = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlClock = new System.Windows.Forms.Panel();
            this.pnlDispute = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSubDispute);
            this.panel1.Controls.Add(this.btnSearchOthr);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnClockio);
            this.panel1.Controls.Add(this.btnPayInfo);
            this.panel1.Controls.Add(this.btnPersInfo);
            this.panel1.Controls.Add(this.btnBenefits);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 600);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Live Chat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(0, 470);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 62);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSubDispute
            // 
            this.btnSubDispute.BackColor = System.Drawing.Color.Black;
            this.btnSubDispute.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDispute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubDispute.Location = new System.Drawing.Point(0, 335);
            this.btnSubDispute.Name = "btnSubDispute";
            this.btnSubDispute.Size = new System.Drawing.Size(158, 53);
            this.btnSubDispute.TabIndex = 8;
            this.btnSubDispute.Text = "Submit Dispute";
            this.btnSubDispute.UseVisualStyleBackColor = false;
            this.btnSubDispute.Click += new System.EventHandler(this.btnSubDispute_Click);
            // 
            // btnSearchOthr
            // 
            this.btnSearchOthr.BackColor = System.Drawing.Color.Black;
            this.btnSearchOthr.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOthr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchOthr.Location = new System.Drawing.Point(0, 229);
            this.btnSearchOthr.Name = "btnSearchOthr";
            this.btnSearchOthr.Size = new System.Drawing.Size(158, 53);
            this.btnSearchOthr.TabIndex = 7;
            this.btnSearchOthr.Text = "Search Coworkers";
            this.btnSearchOthr.UseVisualStyleBackColor = false;
            this.btnSearchOthr.Click += new System.EventHandler(this.btnSearchOthr_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(0, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClockio
            // 
            this.btnClockio.BackColor = System.Drawing.Color.Black;
            this.btnClockio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClockio.Location = new System.Drawing.Point(0, 282);
            this.btnClockio.Name = "btnClockio";
            this.btnClockio.Size = new System.Drawing.Size(158, 53);
            this.btnClockio.TabIndex = 5;
            this.btnClockio.Text = "Clock In/Out";
            this.btnClockio.UseVisualStyleBackColor = false;
            this.btnClockio.Click += new System.EventHandler(this.btnClockio_Click);
            // 
            // btnPayInfo
            // 
            this.btnPayInfo.BackColor = System.Drawing.Color.Black;
            this.btnPayInfo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayInfo.Location = new System.Drawing.Point(0, 176);
            this.btnPayInfo.Name = "btnPayInfo";
            this.btnPayInfo.Size = new System.Drawing.Size(158, 53);
            this.btnPayInfo.TabIndex = 4;
            this.btnPayInfo.Text = "Payment Info";
            this.btnPayInfo.UseVisualStyleBackColor = false;
            this.btnPayInfo.Click += new System.EventHandler(this.btnPayInfo_Click);
            // 
            // btnPersInfo
            // 
            this.btnPersInfo.BackColor = System.Drawing.Color.Black;
            this.btnPersInfo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPersInfo.Location = new System.Drawing.Point(0, 122);
            this.btnPersInfo.Name = "btnPersInfo";
            this.btnPersInfo.Size = new System.Drawing.Size(158, 53);
            this.btnPersInfo.TabIndex = 3;
            this.btnPersInfo.Text = "View Personal info";
            this.btnPersInfo.UseVisualStyleBackColor = false;
            this.btnPersInfo.Click += new System.EventHandler(this.btnPersInfo_Click);
            // 
            // btnBenefits
            // 
            this.btnBenefits.BackColor = System.Drawing.Color.Black;
            this.btnBenefits.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenefits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBenefits.Location = new System.Drawing.Point(0, 69);
            this.btnBenefits.Name = "btnBenefits";
            this.btnBenefits.Size = new System.Drawing.Size(158, 53);
            this.btnBenefits.TabIndex = 1;
            this.btnBenefits.Text = "View Benefits";
            this.btnBenefits.UseVisualStyleBackColor = false;
            this.btnBenefits.Click += new System.EventHandler(this.btnBenefits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.Content);
            this.pnlTop.Controls.Add(this.lblEmp);
            this.pnlTop.Controls.Add(this.Times);
            this.pnlTop.Controls.Add(this.btnExitTop);
            this.pnlTop.Controls.Add(this.Current_time);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(921, 41);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.Location = new System.Drawing.Point(846, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(160, 41);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(763, 590);
            this.Content.TabIndex = 15;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmp.Location = new System.Drawing.Point(363, 7);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(148, 21);
            this.lblEmp.TabIndex = 5;
            this.lblEmp.Text = "Employee\'s name";
            // 
            // Times
            // 
            this.Times.AutoSize = true;
            this.Times.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Times.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Times.Location = new System.Drawing.Point(664, 7);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(58, 21);
            this.Times.TabIndex = 4;
            this.Times.Text = "00 : 00";
            this.Times.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExitTop
            // 
            this.btnExitTop.Image = ((System.Drawing.Image)(resources.GetObject("btnExitTop.Image")));
            this.btnExitTop.Location = new System.Drawing.Point(885, 3);
            this.btnExitTop.Name = "btnExitTop";
            this.btnExitTop.Size = new System.Drawing.Size(33, 33);
            this.btnExitTop.TabIndex = 3;
            this.btnExitTop.UseVisualStyleBackColor = true;
            this.btnExitTop.Click += new System.EventHandler(this.btnExitTop_Click);
            // 
            // Current_time
            // 
            this.Current_time.AutoSize = true;
            this.Current_time.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Current_time.Location = new System.Drawing.Point(607, 7);
            this.Current_time.Name = "Current_time";
            this.Current_time.Size = new System.Drawing.Size(51, 21);
            this.Current_time.TabIndex = 3;
            this.Current_time.Text = "Date:";
            this.Current_time.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcome.Location = new System.Drawing.Point(60, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(265, 21);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to KOCH Payroll system";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackground.Location = new System.Drawing.Point(160, 41);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(761, 600);
            this.pnlBackground.TabIndex = 2;
            // 
            // pnlBenefits
            // 
            this.pnlBenefits.BackColor = System.Drawing.Color.Transparent;
            this.pnlBenefits.Location = new System.Drawing.Point(160, 41);
            this.pnlBenefits.Name = "pnlBenefits";
            this.pnlBenefits.Size = new System.Drawing.Size(760, 600);
            this.pnlBenefits.TabIndex = 0;
            this.pnlBenefits.Visible = false;
            // 
            // pnlPersonInfo
            // 
            this.pnlPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPersonInfo.Location = new System.Drawing.Point(160, 41);
            this.pnlPersonInfo.Name = "pnlPersonInfo";
            this.pnlPersonInfo.Size = new System.Drawing.Size(761, 600);
            this.pnlPersonInfo.TabIndex = 0;
            this.pnlPersonInfo.Visible = false;
            // 
            // pnlPaymentInfo
            // 
            this.pnlPaymentInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPaymentInfo.Location = new System.Drawing.Point(160, 41);
            this.pnlPaymentInfo.Name = "pnlPaymentInfo";
            this.pnlPaymentInfo.Size = new System.Drawing.Size(761, 600);
            this.pnlPaymentInfo.TabIndex = 0;
            this.pnlPaymentInfo.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Location = new System.Drawing.Point(160, 41);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(761, 600);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.Visible = false;
            // 
            // pnlClock
            // 
            this.pnlClock.BackColor = System.Drawing.Color.Transparent;
            this.pnlClock.Location = new System.Drawing.Point(160, 41);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(761, 600);
            this.pnlClock.TabIndex = 0;
            this.pnlClock.Visible = false;
            // 
            // pnlDispute
            // 
            this.pnlDispute.BackColor = System.Drawing.Color.Transparent;
            this.pnlDispute.Location = new System.Drawing.Point(160, 41);
            this.pnlDispute.Name = "pnlDispute";
            this.pnlDispute.Size = new System.Drawing.Size(761, 600);
            this.pnlDispute.TabIndex = 0;
            this.pnlDispute.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(160, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 600);
            this.panel2.TabIndex = 0;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 641);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPersonInfo);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlDispute);
            this.Controls.Add(this.pnlPaymentInfo);
            this.Controls.Add(this.pnlBenefits);
            this.Controls.Add(this.pnlClock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWelcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnBenefits;
        private System.Windows.Forms.Label Current_time;
        private System.Windows.Forms.Label Times;
        private System.Windows.Forms.Label lblEmp;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Button btnPayInfo;
        private System.Windows.Forms.Button btnPersInfo;
        private System.Windows.Forms.Button btnClockio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button btnSearchOthr;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnSubDispute;
        private System.Windows.Forms.Panel pnlDispute;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlPersonInfo;
        private System.Windows.Forms.Panel pnlClock;
        private System.Windows.Forms.Panel pnlBenefits;
        private System.Windows.Forms.Panel pnlPaymentInfo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}

