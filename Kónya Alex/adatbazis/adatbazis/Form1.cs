using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adatbazis
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

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "datasource=127.0.0.1; port= 3306; username= root; password=; database= mozi; SSL Mode=None";
            MySqlConnection kapcsolat = new MySqlConnection(conn);
            kapcsolat.Open();
            string sql = "SELECT * FROM vetites ORDER BY mozinev desc";
            MySqlCommand parancs = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader lekerdez = parancs.ExecuteReader();

            while(lekerdez.Read())
            {
                dataGridView1.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2]);
            }
            kapcsolat.Close();
        }
    }
}
