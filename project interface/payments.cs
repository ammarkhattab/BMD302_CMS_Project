﻿using System;
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
    public partial class payments : UserControl
    {
        public payments()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Rows.Add("cash");
            dt.Rows.Add("creditcard");
            DataRow dr = dt.NewRow();
            dr["Title"] = "Select";
            dt.Rows.InsertAt(dr, 0);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Title";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {

            if (comboBox1.SelectedValue.ToString() == "creditcard")
            {
                if (Application.OpenForms.OfType<credit>().Count() == 1)
                    Application.OpenForms.OfType<credit>().First().Close();
                credit frm = new credit();
                frm.Show();
            }
            else if (comboBox1.SelectedValue.ToString() == "cash")
            {
                if (Application.OpenForms.OfType<cash>().Count() == 1)
                    Application.OpenForms.OfType<cash>().First().Close();
                cash frm = new cash();
                frm.Show();
            }
            
            
        }
    }
}
