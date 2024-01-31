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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup S = new signup();
            this.Hide();
            S.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
