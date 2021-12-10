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

namespace adatbázisproba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB; Database=autok2";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = "SELECT * FROM auto";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();
            while (lekerdez.Read())
            {
                dataGridView1.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2], lekerdez[3], lekerdez[4], lekerdez[5]);
            }
            kapcsolat.Close();
        }
    }
}
