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

namespace GYM
{
    public partial class eqpshow : Form
    {
        public eqpshow()
        {
            InitializeComponent();
        }

        private void eqpshow_Load(object sender, EventArgs e)
        {
            showdetals();
        }
        private void showdetals()
        {

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym;Convert Zero Datetime=true;";

            MySqlConnection conn = new MySqlConnection(connection);

            string query1 = "SELECT * FROM `equipment`";
            MySqlCommand cmd = new MySqlCommand(query1, conn);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
