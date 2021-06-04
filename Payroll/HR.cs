using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class HR : Form
    {
        public HR()
        {
            InitializeComponent();
            label2.Text = "LoginTime:   "+ DateTime.Now.ToString();
        }
    }
}
