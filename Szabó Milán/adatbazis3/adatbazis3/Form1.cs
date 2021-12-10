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


namespace adatbazis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "datasource=127.0.0.1; port=3306;username=root;password=;database=mozi; SSL Mode=None";
            MySqlConnection kapcsolat = new MySqlConnection(conn);
            kapcsolat.Open();
            string sql = "Select*from vetites order by mozinev desc";
            MySqlCommand parancs = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader lekeredez = parancs.ExecuteReader();
            while (lekeredez.Read())
            {
                dataGridView1.Rows.Add(lekeredez[0], lekeredez[1], lekeredez[2]);
            
             
            }
            
            
            
            kapcsolat.Close();

        }
    }
}
