﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventManagement
{
    public partial class departmentform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        public departmentform()
        {
            InitializeComponent();
        }

        private void departmentform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmanagementDataSet14.approval' table. You can move, or remove it, as needed.
            //this.approvalTableAdapter.Fill(this.eventmanagementDataSet14.approval);
            // TODO: This line of code loads data into the 'eventmanagementDataSet7.department' table. You can move, or remove it, as needed.
          //  this.departmentTableAdapter.Fill(this.eventmanagementDataSet7.department);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into department values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("department inserted");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            adminform f = new adminform();
            f.Show();
        }
    }
}
