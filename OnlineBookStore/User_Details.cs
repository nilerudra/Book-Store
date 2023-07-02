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
    public partial class User_Details : Form
    {
        public User_Details()
        {
            InitializeComponent();
        }

        private void User_Details_Load(object sender, EventArgs e)
        {

        }

        private void user_id_Enter(object sender, EventArgs e)
        {
            if (user_name.Text == "Enter Name.")
            {
                user_name.Text = "";
                user_name.ForeColor = Color.Black;
            }
        }

        private void user_id_Leave(object sender, EventArgs e)
        {
            if (user_name.Text == "")
            {
                user_name.Text = "Enter Name.";
                user_name.ForeColor = Color.LightGray;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Enter Email.")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Enter Email.";
                Email.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Phone_no.Text == "Enter Phone no.")
            {
                Phone_no.Text = "";
                Phone_no.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_name.Text) || String.IsNullOrEmpty(Email.Text) || String.IsNullOrEmpty(Phone_no.Text) || String.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("Please Fill All Details");
            }
            else
            {
                try
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    String insertdata = "insert into user_details values('" + user_name.Text + "','" + Email.Text + "','"+Phone_no.Text+"','"+Address.Text+"','"+""+(ImpValues.mail)+"')";
                    obj.cmd.Connection = obj.con;
                    obj.cmd.CommandText = insertdata;
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    MessageBox.Show("Information Successfully Added");
                    UserLogin hp = new UserLogin();
                    hp.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        private void Phone_no_Leave(object sender, EventArgs e)
        {
            if (Phone_no.Text == "")
            {
                Phone_no.Text = "Enter Phone no.";
                Phone_no.ForeColor = Color.LightGray;
            }
        }

        private void Address_Enter(object sender, EventArgs e)
        {
            if (Address.Text == "Enter Address.")
            {
                Address.Text = "";
                Address.ForeColor = Color.Black;
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (Address.Text == "")
            {
                Address.Text = "Enter Address.";
                Address.ForeColor = Color.LightGray;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Enter Address.";
                Email.ForeColor = Color.LightGray;
            }
        }
    }
}
