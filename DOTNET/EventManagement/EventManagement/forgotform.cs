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
    public partial class forgotform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        public forgotform()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginform form4 = new loginform();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select name,password from register where name='"+textBox1.Text+"'",conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("username not available");
                textBox2.Text = "";
            }
        }
    }
}
