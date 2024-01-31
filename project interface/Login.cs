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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Rows.Add("Nurse");
            dt.Rows.Add("Dentist");
            dt.Rows.Add("Patient");

            DataRow dr = dt.NewRow();
            dr["Title"] = "Login as";
            dt.Rows.InsertAt(dr, 0);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Title";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login F1 = new Login();
            Nurse_view F2 = new Nurse_view();
            this.Hide();
            F2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "Nurse")
            {
                if (Application.OpenForms.OfType<Nurse_view>().Count() == 1)
                    Application.OpenForms.OfType<Nurse_view>().First().Close();
                Nurse_view frm = new Nurse_view();
                frm.Show();
                this.Hide();

            }
            else if (comboBox1.SelectedValue.ToString() == "Dentist")
            {
                if (Application.OpenForms.OfType<Dentist_view>().Count() == 1)
                    Application.OpenForms.OfType<Dentist_view>().First().Close();
                Dentist_view frm = new Dentist_view();
                frm.Show();
                this.Hide();

            }
            else if (comboBox1.SelectedValue.ToString() == "Patient")
            {
                if (Application.OpenForms.OfType<patient_view>().Count() == 1)
                    Application.OpenForms.OfType<patient_view>().First().Close();
                patient_view frm = new patient_view();
                frm.Show();
                this.Hide();
            }

        }
    }
}
