using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_interface
{
    public partial class Nurse_view : Form
    {
        public Nurse_view()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            patients1.Hide();
            dentists1.Hide();
            appointments1.Hide();
            payments1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            patients1.Show();
            dentists1.Hide();
            appointments1.Hide();
            payments1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            patients1.Hide();
            dentists1.Show();
            appointments1.Hide();
            payments1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            patients1.Hide();
            dentists1.Hide();
            appointments1.Show();
            payments1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            patients1.Hide();
            dentists1.Hide();
            appointments1.Hide();
            payments1.Show();

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nurseprofile P = new Nurseprofile();
            P.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
