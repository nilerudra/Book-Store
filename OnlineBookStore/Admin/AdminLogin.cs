using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            ui.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin_id.Text != null && admin_pass.Text != null)
            {
                if (admin_id.Text == "RudrAditya" && admin_pass.Text == "GPARABS@it")
                {
                    MessageBox.Show("Admin Login Successful..");
                    Admin.AdminDashboard a = new Admin.AdminDashboard();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter Correct ID and Password..");
                }
            }
        }


        private void AdminLogin_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserInterface u = new UserInterface();
            u.Show();
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (admin_id.Text == "Enter Admin ID")
            {
                admin_id.Text = "";
                admin_id.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (admin_id.Text == "")
            {
                admin_id.Text = "Enter Admin ID";
                admin_id.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (admin_pass.Text == "Password")
            {
                admin_pass.Text = "";
                admin_pass.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (admin_pass.Text == "")
            {
                admin_pass.Text = "Password";
                admin_pass.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
