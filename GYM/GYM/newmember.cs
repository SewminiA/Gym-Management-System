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
using System.Globalization;

namespace GYM
{
    public partial class newmember : Form
    {
       
        public newmember()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;


            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add member

            string gender = radioButton1.Checked ? "Male" : "Female";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || gender == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || dateTimePicker2.Text == "" || textBox4.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else {

                try { 

                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym";
                    MySqlConnection conn = new MySqlConnection(connection);

                    string query = "INSERT INTO `member`(`id`, `fname`, `lname`, `phone`, `gender`, `age`, `gymtime`, `joindate`, `city`, `membership`)  VALUES(NULL,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + dateTimePicker2.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "')";
                    MySqlCommand adddata = new MySqlCommand(query,conn);
                    conn.Open();
                    MySqlDataReader myreader = adddata.ExecuteReader();

                    MessageBox.Show("Added new member");
                    conn.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            
            }


        }

                
                }
               
            }
        
