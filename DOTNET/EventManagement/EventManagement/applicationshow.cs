using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EventManagement
{
    public partial class applicationshow : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;

        public applicationshow()
        {
            InitializeComponent();
        }

        private void applicationshow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmanagementDataSet19.application' table. You can move, or remove it, as needed.
            // this.applicationTableAdapter1.Fill(this.eventmanagementDataSet19.application);
            disp_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userform y = new userform();
            y.Show();
        }
        public void disp_data()
        {
            conn.Open();
            // Make the DataGridView visible
            dataGridView1.Visible = true;

            // Create an adapter to retrieve data from the database
            SqlDataAdapter adpt3 = new SqlDataAdapter("select * from application", conn);

            // Create a DataTable to hold the retrieved data
            DataTable dt3 = new DataTable();

            // Fill the DataTable with data from the database
            adpt3.Fill(dt3);

            // Bind the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dt3;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete button
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from application where aplnid=@AI", conn);
                cmd.Parameters.AddWithValue("@AI", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted");
                conn.Close();
                disp_data();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // update button 
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("update application set aplname=@AN,deptname=@DN,events=@E,date=@D,status=@S", conn);
                    cmd.Parameters.AddWithValue("@AN", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DN", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@E", comboBox2.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@D", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@S", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Inserted");
                    disp_data();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
          //  textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

    }
}
