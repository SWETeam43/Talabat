using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;

namespace Talabat
{
    public partial class open_form : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleCommand c;
        Int32 sh_id=0;

         
        public open_form()
        {
            InitializeComponent();
        }

        private void open_form_Load(object sender, EventArgs e) {

            c = new OracleCommand();
            conn = new OracleConnection(ordb);
        //c = new OracleCommand();
            c.Connection = conn;
            conn.Open();
            /*conn = new OracleConnection(ordb);
             c = new OracleCommand();
             c.Connection = conn;
             conn.Open();*/
            c.CommandText = "SELECT DISTINCT locationn FROM shop";
            c.CommandType = CommandType.Text;
            OracleDataReader rcd = c.ExecuteReader();
            while (rcd.Read())
            {
                comboBox1.Items.Add(rcd[0]);
            }
            
        }

      

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //pharmacy
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Restaurants
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_of_shops.Items.Clear();
            conn = new OracleConnection(ordb);
            c = new OracleCommand();
            c.Connection = conn;
            conn.Open();
            string cmd = "";
            
            if (radioButton1.Checked)
            {
                //Console.WriteLine("hello");
                cmd = "Restaurant";
            }
            else if (radioButton2.Checked)
            {
                cmd = "Pharmacy";
            }
            c.Parameters.Clear();
            c.Parameters.Add("cmd",cmd);
            c.CommandText = "select SHOP_NAME from shop where CATEGORYY=:cmd";

            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                List_of_shops.Items.Add(dr[0]);

            }
            c.CommandText = "select* from shop where CATEGORYY=:cmd";
            c.CommandType = CommandType.Text;
            dr = c.ExecuteReader();
            DataTable inp = new DataTable();
            /*inp.Columns.Add("Shop_id");
            inp.Columns.Add("Categegory");
            inp.Columns.Add("Number_of_braches");
            inp.Columns.Add("Location");

            inp.Columns.Add("Contact");
            inp.Columns.Add("Shop_Name");*/

            //OracleDataReader dr2 = c.ExecuteReader();
            if (dr.HasRows)
            {
                inp.Load(dr);
                product_list.DataSource= inp;

            }
            dr.Close();
            //dr2.Close();
            //conn.Close();
        }



        private void Regestrate_Click(object sender, EventArgs e)
        {
            String[] input = { CATEGORYY.Text.ToString(), NUMBER_OF_BRANCHES.Text.ToString()
                    ,Location.Text.ToString(),CONTACT.Text.ToString(),SHOP_NAME.Text.ToString()};
            if (input[0] =="" || input[1] == "" || input[2] == "" || input[3] == "" ||
                input[4] == "")
            {
                MessageBox.Show("Please, complete all the Data");
            }
            else
            {
                c.CommandText = "select max(SHOP_ID) from shop";
                c.CommandType = CommandType.Text;
                OracleDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    sh_id = Int32.Parse(dr[0].ToString());
                    sh_id++;
                }
                dr.Close();
                c.CommandText = "insert into shop values(:shid,:aa,:bb,:cc,:dd,:ee)";
                c.Parameters.Clear();
                c.Parameters.Add("shid",sh_id);
                c.Parameters.Add("aa", input[0]);
                c.Parameters.Add("bb", Int32.Parse(input[1])); //to number
                c.Parameters.Add("cc", input[2]);
                c.Parameters.Add("dd", input[3]);
                c.Parameters.Add("ee", input[4]);
                int r = c.ExecuteNonQuery();
                if (r != -1) { MessageBox.Show("A new shop is inserted."); }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.CommandText = "MAX_BRANCH";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Clear();
            c.Parameters.Add("sh_id", OracleDbType.Int32, ParameterDirection.Output);
            c.Parameters.Add("category", OracleDbType.Varchar2, 50, null, ParameterDirection.Output);
            c.Parameters.Add("numOfBranches", OracleDbType.Int32, ParameterDirection.Output);
            c.Parameters.Add("location", OracleDbType.Varchar2, 50, null, ParameterDirection.Output); //to number
            c.Parameters.Add("contact", OracleDbType.Int32, ParameterDirection.Output);
            c.Parameters.Add("sh_name", OracleDbType.Varchar2, 50, null, ParameterDirection.Output);
            c.ExecuteNonQuery();
            int sh_id = Convert.ToInt32(c.Parameters["sh_id"].Value.ToString());
            int contact = Convert.ToInt32(c.Parameters["contact"].Value.ToString());
            int numOfBranches = Convert.ToInt32(c.Parameters["numOfBranches"].Value.ToString());
            string category = c.Parameters["category"].Value.ToString();
            string location = c.Parameters["location"].Value.ToString();
            string sh_name = c.Parameters["sh_name"].Value.ToString();

            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Columns.Add("sh_id");
            dt.Columns.Add("category");
            dt.Columns.Add("location");
            dt.Columns.Add("contact");
            dt.Columns.Add("numOfBranches");
            dt.Columns.Add("sh_name");
            row["sh_id"] = sh_id;
            row["category"] = category;
            row["location"] = location;
            row["contact"] = contact;
            row["numOfBranches"] = numOfBranches;
            row["sh_name"] = sh_name;
            dt.Rows.Add(row);
            MaxGridView.DataSource = dt;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            string selectedText = comboBox1.GetItemText(comboBox1.SelectedItem);
            c.CommandText = "Loc_filter";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Clear();
            c.Parameters.Add("shop",OracleDbType.RefCursor,ParameterDirection.Output);
            c.Parameters.Add("loc", selectedText);
            OracleDataReader rd = c.ExecuteReader();
            DataTable dt = new DataTable();
            
            //while (rd.Read())
            //{
                dt.Load(rd);
                dataGridView1.DataSource = dt;
            //}
            rd.Close();
        }

    }
}
