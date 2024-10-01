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
            LoadDepartments();
            txtAppId.ReadOnly = true;
            txtStatus.ReadOnly = true;

        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT deptname FROM department", conn); 

                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbDept.Items.Clear();

                    while (reader.Read())
                    {
                        cmbDept.Items.Add(reader["deptname"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void applicationshow_Load(object sender, EventArgs e)
        {
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
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    dataGridView1.Visible = true;
                    SqlDataAdapter adpt3 = new SqlDataAdapter("SELECT * FROM application", conn);
                    DataTable dt3 = new DataTable();
                    adpt3.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete button
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from application where aplnid=@AI", conn);
                cmd.Parameters.AddWithValue("@AI", txtAppId.Text);
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
            if (txtAplnName.Text == "" || txtStatus.Text == "" || cmbDept.Text == "" || cmbEvents.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("update application set aplname=@AN,deptname=@DN,events=@E,date=@D where aplnid=@ID", conn);
                    cmd.Parameters.AddWithValue("@AN", txtAplnName.Text);
                    cmd.Parameters.AddWithValue("@DN", cmbDept.Text);
                    cmd.Parameters.AddWithValue("@E", cmbEvents.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@D", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@ID", txtAppId.Text);
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
            
            if (e.RowIndex >= 0) 
            {
               
                txtAppId.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAplnName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

               
                LoadDepartments();

                
                string selectedDept = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (cmbDept.Items.Contains(selectedDept))
                {
                    cmbDept.SelectedItem = selectedDept;
                }

                string eventsString = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbEvents.Items.Clear();
                string[] eventsArray = eventsString.Split(',');
                foreach (string eventItem in eventsArray)
                {
                    cmbEvents.Items.Add(eventItem.Trim());
                }
                if (cmbEvents.Items.Count > 0)
                {
                    cmbEvents.SelectedIndex = 0;
                }

             
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtStatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

    }
}
