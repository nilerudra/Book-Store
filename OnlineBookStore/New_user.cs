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
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_mail.Text) || String.IsNullOrEmpty(user_pass.Text) || String.IsNullOrEmpty(conform_pass.Text))
            {
                MessageBox.Show("Please Fill All Details");
            }
            else
            {
                try
                {
                    //MessageBox.Show("" + user_mail.Text + " - " + user_mail.Text.Length);
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    String insertdata = "insert into login_info values('" + user_mail.Text + "','" + user_pass.Text + "')";
                    obj.cmd.Connection = obj.con;
                    obj.cmd.CommandText = insertdata;
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    MessageBox.Show("Account Created Successfully...");
                    User_Details ud = new User_Details();
                    ud.Show();
                    ImpValues.mail = user_mail.Text;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }    
        }

        private void New_user_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w,h);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserInterface u = new UserInterface();
            u.Show();
            this.Close();
        }

        private void user_mail_Enter(object sender, EventArgs e)
        {
            if (user_mail.Text == "Enter User ID")
            {
                user_mail.Text = "";
                user_mail.ForeColor = Color.Black;
            }
        }

        private void user_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_mail_Leave(object sender, EventArgs e)
        {
            if (user_mail.Text == "")
            {
                user_mail.Text = "Enter User ID";
                user_mail.ForeColor = Color.LightGray;
            }
        }

        private void user_pass_Enter(object sender, EventArgs e)
        {
            if (user_pass.Text == "Password")
            {
                user_pass.Text = "";
                user_pass.ForeColor = Color.Black;
            }
        }

        private void user_pass_Leave(object sender, EventArgs e)
        {
            if (user_pass.Text == "")
            {
                user_pass.Text = "Password";
                user_pass.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (conform_pass.Text == "Conform Password")
            {
                conform_pass.Text = "";
                conform_pass.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (conform_pass.Text == "")
            {
                conform_pass.Text = "Conform Password";
                conform_pass.ForeColor = Color.LightGray;
            }
        }

        private void user_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
