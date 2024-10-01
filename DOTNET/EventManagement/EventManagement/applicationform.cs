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
        SqlCommand cmd;
        List<string> selectedEvents = new List<string>();
        

        public applicationform()
        {
            InitializeComponent();
            LoadDepartments();
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

        private void applicationform_Load(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                selectedEvents.Add(checkBox1.Text);
            }
            else
            {
                selectedEvents.Remove(checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                selectedEvents.Add(checkBox2.Text);
            }
            else
            {
                selectedEvents.Remove(checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                selectedEvents.Add(checkBox3.Text);
            }
            else
            {
                selectedEvents.Remove(checkBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCheckboxes = string.Join(", ", selectedEvents);

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO application (aplname, deptname, events, date, status) VALUES (@Name, @Dept, @Events, @Date, @Status)", conn);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Dept", cmbDept.Text);
                    cmd.Parameters.AddWithValue("@Events", selectedCheckboxes);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value); 
                    cmd.Parameters.AddWithValue("@Status", "not approved");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERTED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
             }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userform y = new userform();
            y.Show();
        }
    }
}
