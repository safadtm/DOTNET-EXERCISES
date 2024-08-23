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
    public partial class adminformviewapplication : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        public adminformviewapplication()
        {
            InitializeComponent();
        }

        private void adminformviewapplication_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'eventmanagementDataSet21.approval' table. You can move, or remove it, as needed.
            //this.approvalTableAdapter2.Fill(this.eventmanagementDataSet21.approval);
            // TODO: This line of code loads data into the 'eventmanagementDataSet20.application' table. You can move, or remove it, as needed.
            // this.applicationTableAdapter2.Fill(this.eventmanagementDataSet20.application);
            fillDropDown();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            adminform y = new adminform();
            y.Show();
        }
        void fillDropDown()
        {
            conn.Open();
            string query = "select aplnid,status from application";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader res = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (res.Read())
            {
                comboBox1.Items.Add(res["aplnid"].ToString());

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update application set status=@ST where aplnid=@AI", conn);
            cmd.Parameters.AddWithValue("@AI", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ST", comboBox2.SelectedItem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully");
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void tableFill(string id)
        {
            conn.Open();
            dataGridView1.Visible = true;
            SqlDataAdapter adpt3 = new($"select * from application where aplnid = '{id}'", conn);
            DataTable dt3 = new DataTable();
            adpt3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            conn.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            tableFill(comboBox1.SelectedItem.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        
    }
}
