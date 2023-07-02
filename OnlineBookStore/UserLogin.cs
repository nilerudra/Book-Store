using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineBookStore
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect c = new Connect();
                c.con.ConnectionString = c.locate;
                c.con.Open();
                string selectQuery = "select uid from login_info where uid ='" + user_id.Text + "'and upass='" + pass.Text + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, c.con);
                String s1 = (String)cmd.ExecuteScalar();
                /* DataTable dt = new DataTable();
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);*/


                if (user_id.Text.Equals(s1))
                {
                    Home_page hp = new Home_page();
                    hp.Show();
                    this.Hide();
                    MessageBox.Show("Login Successful");
                    ImpValues.uname = user_id.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password....");
                }
                c.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Username and Password" + ex);
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            ui.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            New_user ns = new New_user();
            ns.Show();
            this.Close();
        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_id_Enter(object sender, EventArgs e)
        {
            if (user_id.Text == "Enter user ID.")
            {
                user_id.Text = "";
                user_id.ForeColor = Color.Black;
            }
        }

        private void user_id_Leave(object sender, EventArgs e)
        {
            if (user_id.Text == "")
            {
                user_id.Text = "Enter user ID.";
                user_id.ForeColor = Color.LightGray;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Enter Password.")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Enter Password.";
                pass.ForeColor = Color.LightGray;
            }
        }

       
    }
}
