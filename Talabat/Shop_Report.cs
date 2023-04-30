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
    
    public partial class Shop_Report : Form
    {
        ShopReport SR;
        public Shop_Report()
        {
            InitializeComponent();
        }

        private void Shop_Report_Load(object sender, EventArgs e)
        {
            SR = new ShopReport();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = SR;
        }
    }
}
