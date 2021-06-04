namespace Payroll
{
    partial class frmSearchOthers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchOthers));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnSearchnow = new System.Windows.Forms.Button();
            this.lblEmpid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchqryres = new System.Windows.Forms.Label();
            this.lblEmpidres = new System.Windows.Forms.Label();
            this.lblEmpidtex = new System.Windows.Forms.Label();
            this.lblPhoneres = new System.Windows.Forms.Label();
            this.lblFnameres = new System.Windows.Forms.Label();
            this.lblEmailres = new System.Windows.Forms.Label();
            this.lblWorktex = new System.Windows.Forms.Label();
            this.lblFnametex = new System.Windows.Forms.Label();
            this.lblEmailtex = new System.Windows.Forms.Label();
            this.lblDepres = new System.Windows.Forms.Label();
            this.lblDeptex = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbSearch.Controls.Add(this.tbID);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lblFname);
            this.gbSearch.Controls.Add(this.btnSearchnow);
            this.gbSearch.Controls.Add(this.lblEmpid);
            this.gbSearch.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSearch.Location = new System.Drawing.Point(161, 30);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(475, 192);
            this.gbSearch.TabIndex = 18;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Seach for a Coworker";
            // 
            // tbID
            // 
            this.tbID.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbID.Location = new System.Drawing.Point(246, 84);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(172, 27);
            this.tbID.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbName.Location = new System.Drawing.Point(246, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 27);
            this.tbName.TabIndex = 11;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFname.Location = new System.Drawing.Point(58, 44);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(63, 21);
            this.lblFname.TabIndex = 10;
            this.lblFname.Text = "Name:";
            // 
            // btnSearchnow
            // 
            this.btnSearchnow.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchnow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchnow.Location = new System.Drawing.Point(176, 139);
            this.btnSearchnow.Name = "btnSearchnow";
            this.btnSearchnow.Size = new System.Drawing.Size(96, 31);
            this.btnSearchnow.TabIndex = 9;
            this.btnSearchnow.Text = "Seach Now";
            this.btnSearchnow.UseVisualStyleBackColor = true;
            this.btnSearchnow.Click += new System.EventHandler(this.BtnSearchnow_Click);
            // 
            // lblEmpid
            // 
            this.lblEmpid.AutoSize = true;
            this.lblEmpid.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmpid.Location = new System.Drawing.Point(57, 84);
            this.lblEmpid.Name = "lblEmpid";
            this.lblEmpid.Size = new System.Drawing.Size(110, 21);
            this.lblEmpid.TabIndex = 6;
            this.lblEmpid.Text = "Employee ID:";
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
            this.groupBox1.Controls.Add(this.lblDepres);
            this.groupBox1.Controls.Add(this.lblDeptex);
            this.groupBox1.Controls.Add(this.lblSearchqryres);
            this.groupBox1.Controls.Add(this.lblEmpidres);
            this.groupBox1.Controls.Add(this.lblEmpidtex);
            this.groupBox1.Controls.Add(this.lblPhoneres);
            this.groupBox1.Controls.Add(this.lblFnameres);
            this.groupBox1.Controls.Add(this.lblEmailres);
            this.groupBox1.Controls.Add(this.lblWorktex);
            this.groupBox1.Controls.Add(this.lblFnametex);
            this.groupBox1.Controls.Add(this.lblEmailtex);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(161, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 350);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Results";
            // 
            // lblSearchqryres
            // 
            this.lblSearchqryres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchqryres.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchqryres.Location = new System.Drawing.Point(113, 35);
            this.lblSearchqryres.Name = "lblSearchqryres";
            this.lblSearchqryres.Size = new System.Drawing.Size(249, 96);
            this.lblSearchqryres.TabIndex = 19;
            this.lblSearchqryres.Text = "Search Result:";
            this.lblSearchqryres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpidres
            // 
            this.lblEmpidres.AutoSize = true;
            this.lblEmpidres.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpidres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmpidres.Location = new System.Drawing.Point(242, 219);
            this.lblEmpidres.Name = "lblEmpidres";
            this.lblEmpidres.Size = new System.Drawing.Size(59, 21);
            this.lblEmpidres.TabIndex = 18;
            this.lblEmpidres.Text = "RESULT";
            // 
            // lblEmpidtex
            // 
            this.lblEmpidtex.AutoSize = true;
            this.lblEmpidtex.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpidtex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmpidtex.Location = new System.Drawing.Point(58, 219);
            this.lblEmpidtex.Name = "lblEmpidtex";
            this.lblEmpidtex.Size = new System.Drawing.Size(110, 21);
            this.lblEmpidtex.TabIndex = 17;
            this.lblEmpidtex.Text = "Employee ID:";
            // 
            // lblPhoneres
            // 
            this.lblPhoneres.AutoSize = true;
            this.lblPhoneres.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneres.Location = new System.Drawing.Point(243, 281);
            this.lblPhoneres.Name = "lblPhoneres";
            this.lblPhoneres.Size = new System.Drawing.Size(59, 21);
            this.lblPhoneres.TabIndex = 15;
            this.lblPhoneres.Text = "RESULT";
            // 
            // lblFnameres
            // 
            this.lblFnameres.AutoSize = true;
            this.lblFnameres.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFnameres.Location = new System.Drawing.Point(243, 157);
            this.lblFnameres.Name = "lblFnameres";
            this.lblFnameres.Size = new System.Drawing.Size(59, 21);
            this.lblFnameres.TabIndex = 14;
            this.lblFnameres.Text = "RESULT";
            // 
            // lblEmailres
            // 
            this.lblEmailres.AutoSize = true;
            this.lblEmailres.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailres.Location = new System.Drawing.Point(243, 250);
            this.lblEmailres.Name = "lblEmailres";
            this.lblEmailres.Size = new System.Drawing.Size(59, 21);
            this.lblEmailres.TabIndex = 13;
            this.lblEmailres.Text = "RESULT";
            // 
            // lblWorktex
            // 
            this.lblWorktex.AutoSize = true;
            this.lblWorktex.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorktex.Location = new System.Drawing.Point(58, 281);
            this.lblWorktex.Name = "lblWorktex";
            this.lblWorktex.Size = new System.Drawing.Size(77, 21);
            this.lblWorktex.TabIndex = 11;
            this.lblWorktex.Text = "Phone #:";
            // 
            // lblFnametex
            // 
            this.lblFnametex.AutoSize = true;
            this.lblFnametex.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnametex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFnametex.Location = new System.Drawing.Point(58, 157);
            this.lblFnametex.Name = "lblFnametex";
            this.lblFnametex.Size = new System.Drawing.Size(63, 21);
            this.lblFnametex.TabIndex = 10;
            this.lblFnametex.Text = "Name:";
            // 
            // lblEmailtex
            // 
            this.lblEmailtex.AutoSize = true;
            this.lblEmailtex.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailtex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailtex.Location = new System.Drawing.Point(58, 250);
            this.lblEmailtex.Name = "lblEmailtex";
            this.lblEmailtex.Size = new System.Drawing.Size(130, 21);
            this.lblEmailtex.TabIndex = 6;
            this.lblEmailtex.Text = "E-mail Address:";
            // 
            // lblDepres
            // 
            this.lblDepres.AutoSize = true;
            this.lblDepres.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepres.Location = new System.Drawing.Point(243, 188);
            this.lblDepres.Name = "lblDepres";
            this.lblDepres.Size = new System.Drawing.Size(59, 21);
            this.lblDepres.TabIndex = 21;
            this.lblDepres.Text = "RESULT";
            // 
            // lblDeptex
            // 
            this.lblDeptex.AutoSize = true;
            this.lblDeptex.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeptex.Location = new System.Drawing.Point(58, 188);
            this.lblDeptex.Name = "lblDeptex";
            this.lblDeptex.Size = new System.Drawing.Size(107, 21);
            this.lblDeptex.TabIndex = 20;
            this.lblDeptex.Text = "Department:";
            // 
            // frmSearchOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchOthers";
            this.Text = "Search_history";
            this.Load += new System.EventHandler(this.Search_history_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnSearchnow;
        private System.Windows.Forms.Label lblEmpid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpidres;
        private System.Windows.Forms.Label lblEmpidtex;
        private System.Windows.Forms.Label lblPhoneres;
        private System.Windows.Forms.Label lblFnameres;
        private System.Windows.Forms.Label lblEmailres;
        private System.Windows.Forms.Label lblWorktex;
        private System.Windows.Forms.Label lblFnametex;
        private System.Windows.Forms.Label lblEmailtex;
        private System.Windows.Forms.Label lblSearchqryres;
        private System.Windows.Forms.Label lblDepres;
        private System.Windows.Forms.Label lblDeptex;
    }
}