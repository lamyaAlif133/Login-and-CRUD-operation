using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Final_Term
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-FCC0LMK6\\SQLEXPRESS;Initial Catalog=\"My TestDB\";Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            if (password.Text == cpassword.Text)
            {
                SqlCommand cmd = new SqlCommand("insert into usertable values (@username,@password) ", con);

                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", int.Parse(password.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Registered");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password Did Not Match");
            }
        }
    }
}
