using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Payroll
{
    public partial class frmLogin : Form
    {
        string connectionString;
        SqlConnection connection;
        
        public frmLogin()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;

        }

        // Code to move form by simply clicking on it
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        // code ends here

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPassword.Text = "";
            this.txtPassword.PasswordChar = '*';
            // to fix issue of show password checked before entering password
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                //this.button1.Focus();
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
               this.txtPassword.Clear();
               this.txtPassword.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string EmpID = txtEmpId.Text;
            string password = txtPassword.Text;
            int id;
            
            string con = "SELECT [Employee ID],Password FROM  Current_Employees where [Employee ID] = '" + EmpID + "' and Password = '" + password + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                try
                {
                    id = int.Parse(txtEmpId.Text);
                }
                catch
                {
                    id = 0;
                }
                if (EmpID == "" && password == "")
                {
                    MessageBox.Show("The ID & password fields cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (EmpID == "")
                {
                    MessageBox.Show("The ID field cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtEmpId.Focus();
                }
                else if (password == "")
                {
                    MessageBox.Show("The password field cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Focus();
                }
                //SQL check to login 
                //this is testing login code
                else if (n > 0)
                {
                    if (id / 1000000 == 801)
                    {
                        MessageBox.Show("Access granted, welcome HR User!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Human_Resource HR = new Human_Resource(EmpID);
                        HR.Show();
                        this.Hide();
                    }
                    else if (id / 1000000 == 101)
                    {
                        MessageBox.Show("Access granted, welcome Employee!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmEmployee emp = new frmEmployee(EmpID);
                        emp.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("The employee ID and/or password entered is not correct.\nPlease try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void TxtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                this.txtPassword.Focus();
                this.txtPassword.Clear();
                this.txtPassword.PasswordChar = '*';
            }
        }

        private void TxtEmpId_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtEmpId.Text = "";
        }

        private void LinklblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmTEAM KOCH = new frmTEAM())
                KOCH.ShowDialog();
            this.Show();
        }
    }
}
