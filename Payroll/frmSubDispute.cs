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
    public partial class frmSubDispute: Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmSubDispute(string empid)
        {
            id = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void frmSubDispute_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubDispute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to send this claim to the HR Team?", "Please Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //string con = "INSERT INTO [Requests] ([Employee ID], [Issue]) VALUES('@id', '@text', '@0')";
                string con = "INSERT INTO Requests ([Employee ID], [Issue], [Solved]) VALUES(@id, @text, 0)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@text", tbDispute.Text);
                    command.Parameters.AddWithValue("0", false);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Error inserting data into database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                MessageBox.Show("Claim was submitted succesfully!", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbDispute.Clear();
            }
        }
    }
}
