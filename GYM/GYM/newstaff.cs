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
    public partial class newstaff : Form
    {
        public newstaff()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add staff member

            string gender = radioButton1.Checked ? "Male" : "Female";

            if ( textBox2.Text == "" || textBox3.Text == "" || gender == "" || dateTimePicker1.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }

            else
            {

                try
                {

                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym";
                    MySqlConnection conn = new MySqlConnection(connection);

                    string query = "INSERT INTO `staff`(`id`, `name`, `phone`, `gender`, `jdate`) VALUES(NULL,'" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + dateTimePicker1.Text + "')";
                    MySqlCommand adddata = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader myreader = adddata.ExecuteReader();

                    MessageBox.Show("Added new staff member");
                    conn.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset

            textBox2.Text = "";
            textBox3.Text = "";

            dateTimePicker1.Value = DateTime.Now;

            radioButton1.Checked = false;
            radioButton2.Checked = false;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
