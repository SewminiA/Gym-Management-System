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
    public partial class deleqp : Form
    {
        public deleqp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset

            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete equipment
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym";
            try
            {
                MySqlConnection conn = new MySqlConnection(connection);
                string query2 = "DELETE FROM equipment where id='" + textBox2.Text + "'";
                MySqlCommand addData = new MySqlCommand(query2, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("gym equipment successfully deleted.");
                conn.Close();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("error" + ex.ToString());

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
