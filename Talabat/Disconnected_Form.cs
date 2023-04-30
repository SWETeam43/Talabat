using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Talabat
{
    public partial class Disconnected_Form : Form
    {
        string Dmd = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        DataSet data;
        public Disconnected_Form()
        {
            InitializeComponent();
        }

        private void Disconnected_Form_Load(object sender, EventArgs e)
        {
            string cmd = "select USERNAME from CUSTOMER";
            adapter = new OracleDataAdapter(cmd, Dmd);
            ds = new DataSet();
            adapter.Fill(ds);
            userName.DisplayMember = "USERNAME";
            userName.DataSource = ds.Tables[0];
     
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            string name = userName.GetItemText(userName.SelectedItem);
            string cmd = "select rd.product_id,rd.customer_id,rd.shop_id,status,costt,payment_method,delivery_locaction from orderr rd where customer_id =(select CUSTOMER_ID from customer where USERNAME=:username)";
            adapter = new OracleDataAdapter(cmd, Dmd);
            adapter.SelectCommand.Parameters.Add("username", name);
            data = new DataSet();
            adapter.Fill(data);
            OrdersView.DataSource = data.Tables[0];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(data.Tables[0]);
        }
    }
}
