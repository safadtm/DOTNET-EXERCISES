﻿using System.Data;
using System.Data.SqlClient;
namespace EventManagement
{
    public partial class loginform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from register where(email='" + textBox1.Text + "'and password='" + textBox2.Text + "')", conn);
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                DataTable dtm = new DataTable();
                sda = new SqlDataAdapter("select usertype from register where(email='" + textBox1.Text + "'and password='" + textBox2.Text + "')", conn);
                sda.Fill(dtm);
                if (dtm.Rows[0][0].ToString() == "user")
                {
                    this.Hide();
                    userform form4 = new userform();
                    form4.Show();
                }
                else if (dtm.Rows[0][0].ToString() == "admin")
                {
                    this.Hide();
                    adminform form5 = new adminform();
                    form5.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            resetpassword obj = new resetpassword();
            obj.Show();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgotform obj1 = new forgotform();
            obj1.Show();
        }
    }
}
