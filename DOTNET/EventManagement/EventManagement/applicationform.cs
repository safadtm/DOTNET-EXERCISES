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
