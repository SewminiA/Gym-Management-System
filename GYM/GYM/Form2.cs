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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //equipments
            neweqp eqp = new neweqp();
            eqp.Show();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            deletedetails dd = new deletedetails();
            dd.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //registration form
            newmember reg = new newmember();
            reg.Show();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            detailslist detail = new detailslist();
            detail.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newstaff stf = new newstaff();
            stf.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //fees
            feesadd fees = new feesadd();
            fees.Show();

        }
    }
}
