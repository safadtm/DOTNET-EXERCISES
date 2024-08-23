using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class applicationform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        string str = "null";

        public applicationform()
        {
            InitializeComponent();
        }

        private void applicationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmanagementDataSet13.department' table. You can move, or remove it, as needed.
          //  this.departmentTableAdapter3.Fill(this.eventmanagementDataSet13.department);
            // TODO: This line of code loads data into the 'eventmanagementDataSet12.department' table. You can move, or remove it, as needed.
          //  this.departmentTableAdapter2.Fill(this.eventmanagementDataSet12.department);
            // TODO: This line of code loads data into the 'eventmanagementDataSet11.department' table. You can move, or remove it, as needed.
          //  this.departmentTableAdapter1.Fill(this.eventmanagementDataSet11.department);
            // TODO: This line of code loads data into the 'eventmanagementDataSet10.application' table. You can move, or remove it, as needed.
          //  this.applicationTableAdapter2.Fill(this.eventmanagementDataSet10.application);
            // TODO: This line of code loads data into the 'eventmanagementDataSet9.application' table. You can move, or remove it, as needed.
          //  this.applicationTableAdapter1.Fill(this.eventmanagementDataSet9.application);
            // TODO: This line of code loads data into the 'eventmanagementDataSet8.application' table. You can move, or remove it, as needed.
          //  this.applicationTableAdapter.Fill(this.eventmanagementDataSet8.application);
            // TODO: This line of code loads data into the 'eventmanagementDataSet6.department' table. You can move, or remove it, as needed.
          //  this.departmentTableAdapter.Fill(this.eventmanagementDataSet6.department);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            str = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            str = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            str = checkBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into application values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + str + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("INSERTED");
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userform y = new userform();
            y.Show();
        }
    }
}
