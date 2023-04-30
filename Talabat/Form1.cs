using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talabat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void open_mode_Click(object sender, EventArgs e)
        {
            open_form once = new open_form();
            once.Show();
            Hide();
        }

        private void closed_mode_Click(object sender, EventArgs e)
        {
            Disconnected_Form formTwo = new Disconnected_Form();
            formTwo.Show();
            Hide();
        }

        private void reportButton1_Click(object sender, EventArgs e)
        {
            Shop_Report report1 = new Shop_Report();
            report1.Show();
            Hide();
        }

        private void reportButton2_Click(object sender, EventArgs e)
        {
            Customer_report report2 = new Customer_report();
            report2.Show();
            Hide();
        }
    }
}
