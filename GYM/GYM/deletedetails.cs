using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class deletedetails : Form
    {
        public deletedetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //members

            deletmember deletmem = new deletmember();
            deletmem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delstaf deletes = new delstaf();
            deletes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete form

            deleqp deleteeqp = new deleqp();
            deleteeqp.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
