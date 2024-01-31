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
    public partial class Dentist_view : Form
    {
        public Dentist_view()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dentistprofile D = new Dentistprofile();
            D.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dentist_dashboard1.Show();
            dentist_schedule1.Hide();
            dentist_assesment1.Hide();
            dentist_patient1.Hide();
            dentist_payment1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dentist_dashboard1.Hide();
            dentist_schedule1.Hide();
            dentist_assesment1.Hide();
            dentist_patient1.Show();
            dentist_payment1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dentist_dashboard1.Hide();
            dentist_schedule1.Hide();
            dentist_assesment1.Show();
            dentist_patient1.Hide();
            dentist_payment1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dentist_dashboard1.Hide();
            dentist_schedule1.Show();
            dentist_assesment1.Hide();
            dentist_patient1.Hide();
            dentist_payment1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dentist_dashboard1.Hide();
            dentist_schedule1.Hide();
            dentist_assesment1.Hide();
            dentist_patient1.Hide();
            dentist_payment1.Show();
        }

        private void dentist_dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
