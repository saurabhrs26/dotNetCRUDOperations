using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArchitectureCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN=new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
               using(MySqlCommand cmd = new MySqlCommand())
                {
                    CN.Open();
                    cmd.Connection = CN;    
                    cmd.CommandType= CommandType.StoredProcedure;
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable("customerInfo");
                    dt.Load(dataReader);
                    dataGridView1.DataSource = dt;
                    CN.Close();




                }

            }
        }*/

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    CN.Open();
                    cmd.Connection = CN;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllCustomers";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("customerinfo");
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    CN.Close();




                }

            }

        }
    }
}
