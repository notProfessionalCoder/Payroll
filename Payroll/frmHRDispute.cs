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
    public partial class frmHRDispute : Form
    {
        string connectionString;
        SqlConnection connection;
        string employeeid;
        public frmHRDispute(string empid)
        {
            employeeid = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void FrmHRDispute_Load(object sender, EventArgs e)
        {
          this.dataGridView1.DataSource = BindingModel().Tables[0];
        }
        private DataSet BindingModel()
        {
            DataSet ds = new DataSet();
            string con = "SELECT [Employee ID], Issue, Solved, Claimer, Resolution FROM Requests WHERE Solved = '0' ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Requests");
            }
            return ds;

        }

        private void BtnClmdispute_Click(object sender, EventArgs e)
        {
            if (cbSolve.Checked)
            {
                MessageBox.Show("You cannot claim a dispute that was already resolved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string conName = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + employeeid + "'";
                string hrName;
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(conName, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    hrName = dt.Rows[0]["Name"].ToString();
                }


                string con = "UPDATE Requests SET Claimer = @hrName WHERE [Employee ID] = @id AND Issue = @text";
                int r = this.dataGridView1.CurrentRow.Index;
                string ID = this.dataGridView1.Rows[r].Cells[0].Value.ToString();
                string text = this.dataGridView1.Rows[r].Cells[1].Value.ToString();
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@text", text);
                    command.Parameters.AddWithValue("@hrName", hrName);
                    connection.Open();
                    command.ExecuteNonQuery();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Error claiming dispute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

                this.dataGridView1.DataSource = BindingModel().Tables[0]; // to refresh page, showing the person who claimed the case

                string textTwo = "Dispute: " + this.dataGridView1.Rows[r].Cells[1].Value.ToString() + "\n\n- This dispute is now claimed! -";
                MessageBox.Show(textTwo, "Dispute Claim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSlvdispute_Click(object sender, EventArgs e)
        {
            if (cbSolve.Checked)
            {
                MessageBox.Show("You cannot solve a dispute already resolved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBox1.Text == "" || this.textBox1.Text == null)
            {
                MessageBox.Show("Please input a solution to the dispute.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Incase HR user forgot to claim the dispute before solving the dispute, this automatically assigns him as the claimer before solving
                //
                //
                string conName = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + employeeid + "'";
                string hrName;
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(conName, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    hrName = dt.Rows[0]["Name"].ToString();
                }


                string con2 = "UPDATE Requests SET Claimer = @hrName WHERE [Employee ID] = @id AND Issue = @text";
                int r2 = this.dataGridView1.CurrentRow.Index;
                string ID2 = this.dataGridView1.Rows[r2].Cells[0].Value.ToString();
                string text2 = this.dataGridView1.Rows[r2].Cells[1].Value.ToString();
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con2, connection))
                {
                    command.Parameters.AddWithValue("@id", ID2);
                    command.Parameters.AddWithValue("@text", text2);
                    command.Parameters.AddWithValue("@hrName", hrName);
                    connection.Open();
                    command.ExecuteNonQuery();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Error claiming dispute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                //
                //
                // END OF SAID CODE

                // This is the beginning of the code for adding the resolution to the database
                string con = "UPDATE Requests SET Solved = '1', Resolution = @resolution  WHERE [Employee ID] = @id AND Issue = @text";
                int r = this.dataGridView1.CurrentRow.Index;
                string ID = this.dataGridView1.Rows[r].Cells[0].Value.ToString();
                string text = this.dataGridView1.Rows[r].Cells[1].Value.ToString();
                string resolution = this.textBox1.Text;
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@text", text);
                    command.Parameters.AddWithValue("@resolution", resolution);
                    connection.Open();
                    command.ExecuteNonQuery();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Error solving dispute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[r]);
            }

        }

        private DataSet BindingModelSolved()
        {
            DataSet ds = new DataSet();
            string con = "SELECT [Employee ID], Issue, Solved, Claimer, Resolution FROM Requests WHERE Solved = '1' ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Requests");
            }
            return ds;

        }

        private void cbSolve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSolve.Checked)
            {
                this.dataGridView1.DataSource = BindingModelSolved().Tables[0];
            }
            else
            {
                this.dataGridView1.DataSource = BindingModel().Tables[0];
            }
        }
    }
}
