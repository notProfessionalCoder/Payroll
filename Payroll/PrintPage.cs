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
    public partial class PrintPage : Form
    {
        string id;
        string no;
        string connectionString;
        SqlConnection connection;
  
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public PrintPage(string payid, string checkno)
        {
            id = payid;
            no = checkno;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void BtnPrintSetting_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void BtnPrintView_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int currentY = 0;

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int awidth = panel2.DisplayRectangle.Width;
            int aheight = panel2.DisplayRectangle.Height;

            System.Drawing.Printing.PrintDocument pd = sender as System.Drawing.Printing.PrintDocument;
            int pwidth = pd.DefaultPageSettings.Bounds.Width;
            int pheight = pd.DefaultPageSettings.Bounds.Height;

            if(currentY < aheight)
            {
                Bitmap bmp = new Bitmap(awidth, aheight);
                panel2.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                e.Graphics.DrawImage(bmp, (pwidth - bmp.Width) / 2, 0, new RectangleF(0, currentY, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                currentY += pheight;
                if(aheight - currentY > 0)
                {
                    e.HasMorePages = true;
                }
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintPage_Load(object sender, EventArgs e)
        {
            this.lblCheckdate.Text = DateTime.Now.ToString("d");

            long hour, min, sec,totalTime;
            string con = "Select * FROM Paycheck WHERE [Employee ID] = '" + id + "' and checkNo = '"+ no +"'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if (n > 0)
                {
                    this.label4.Text = dt.Rows[0]["submitDate"].ToString();
                    this.label10.Text = DateTime.Now.Date.ToLongDateString();
                    this.label48.Text += dt.Rows[0]["Gross Pay"].ToString();
                    this.label39.Text += dt.Rows[0]["Net Pay"].ToString();
                    this.lblcheckMoney.Text += dt.Rows[0]["Net Pay"].ToString(); // FOR check money (white text box with money paid)

                    decimal moneyWords = decimal.Parse(lblcheckMoney.Text); // to convert money from numerical to words and
                    this.lblMoneywords.Text = DecimalToWords(moneyWords); // display it on check

                    this.lblChecknumber.Text = dt.Rows[0]["checkNo"].ToString(); // FOR check number (top right of check)
                    this.lblRoutingnum.Text = dt.Rows[0]["routeNo"].ToString(); // FOR check routing number (bottom left of check)
                    this.lblAccountnum.Text = dt.Rows[0]["accountNo"].ToString(); // FOR check account number (bottom left, second number of check)
                    this.label65.Text += dt.Rows[0]["Benifit"].ToString();
                    this.label31.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["Federal Income Tax"].ToString())),2);
                    this.label32.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["Social Security Tax"].ToString())), 2);
                    this.label33.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["Medicare Tax"].ToString())), 2);
                    this.label34.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["State Income Tax"].ToString())), 2);
                    this.label35.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["State Local Tax"].ToString())), 2);
                    this.label36.Text += Math.Round((double.Parse(dt.Rows[0]["Gross Pay"].ToString()) * double.Parse(dt.Rows[0]["FICA"].ToString())), 2);
                    this.label44.Text += dt.Rows[0]["401K Saved"].ToString();
                    totalTime = long.Parse(dt.Rows[0]["Paid Hours in s"].ToString());
                    hour = totalTime / 3600;
                    min = (totalTime / 60) - (hour * 60);
                    sec = totalTime % 60;
                    this.label50.Text = hour.ToString("00") + " : " + min.ToString("00") + " : " + sec.ToString("00");
                }
                else
                {
                    MessageBox.Show("The employee ID and/or check number are incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
            }
            con = "SELECT Name,Address, City, [Zip Code],State,[Marital Status] FROM Current_Employees WHERE [Employee ID] = '" + id + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if (n > 0)
                {
                    this.label11.Text = dt.Rows[0]["Name"].ToString();
                    this.lblCheckname.Text = dt.Rows[0]["Name"].ToString(); // FOR CHECK NAME
                    this.label12.Text = dt.Rows[0]["Address"].ToString() + ", " + dt.Rows[0]["City"].ToString();
                    this.label13.Text = dt.Rows[0]["State"].ToString() + ", " + dt.Rows[0]["Zip Code"].ToString();
                    this.label16.Text = dt.Rows[0]["Marital Status"].ToString();
                }
                else
                {
                    //MessageBox.Show("Therefore, print form will not open up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Message here is not needed.
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblcheckMoney_Click(object sender, EventArgs e)
        {

        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        public string DecimalToWords(decimal number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + DecimalToWords(Math.Abs(number));

            string words = "";

            int intPortion = (int)number;
            decimal fraction = (number - intPortion) * 100;
            int decPortion = (int)fraction;

            words = NumberToWords(intPortion);
            if (decPortion > 0)
            {
                words += " and ";
                words += NumberToWords(decPortion);
            }
            return words;
        }

    }
}
