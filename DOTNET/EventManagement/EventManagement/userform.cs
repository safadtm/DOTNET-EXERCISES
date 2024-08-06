using System.Data.SqlClient;

namespace EventManagement
{
    public partial class userform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RPVNF73V;Initial Catalog=EventManagement;Integrated Security=True");
        SqlCommand cmd;
        public userform()
        {
            InitializeComponent();
        }

        private void userform_Load(object sender, EventArgs e)
        {

        }

        private void myApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform h = new loginform();
            h.Show();
        }
    }
}
