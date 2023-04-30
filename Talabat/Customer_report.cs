using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Talabat
{
    public partial class Customer_report : Form
    {
        CustomerReport CR;
        public Customer_report()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void Customer_report_Load(object sender, EventArgs e)
        {
            CR = new CustomerReport();
        }
    }
}
