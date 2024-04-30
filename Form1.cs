using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Assignment_Final_Term

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-FCC0LMK6\\SQLEXPRESS;Initial Catalog=\"My TestDB\";Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM usertable WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", textUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("login Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CRUD form1 = new CRUD();
                form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error In login");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
