using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform form1 = new loginform();
            form1.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            userform form1 = new userform();
            form1.Show();
        }

        private void addApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            departmentform form6 = new departmentform();
            form6.Show();
        }

        private void viewApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminformviewapplication form11 = new adminformviewapplication();
            this.Hide();
            form11.Show();
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }
    }
}
