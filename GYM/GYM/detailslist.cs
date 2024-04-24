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


namespace GYM
{
    public partial class detailslist : Form
    {
        
        public detailslist()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //member show

            membershow member = new membershow();
            member.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffshow ss = new staffshow();
            ss.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            eqpshow eqps = new eqpshow();
            eqps.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feesshow fs = new feesshow();
            fs.Show();
        }
    }
}
