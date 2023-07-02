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
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void Home_page_Load(object sender, EventArgs e)
        {

        }

        public static String fetch_user_add()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String data = "select address from user_details where user_id= '" + ImpValues.uname + "'";
                SqlCommand cmd = new SqlCommand(data, obj.con);
                String s1 = (String)cmd.ExecuteScalar();
                obj.con.Close();
                return s1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
                return "";
            }
        }

        public static String fetch_user_name()
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String data = "select name from user_details where user_id= '" + ImpValues.uname + "'";
                SqlCommand cmd = new SqlCommand(data, obj.con);
                String s1 = (String)cmd.ExecuteScalar();
                obj.con.Close();
                return s1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
                return "";
            }
        }

        public static String fetch_book_price(String bname)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String price = "select book_price from book_info where book_name= '" + bname + "'";
                SqlCommand cmd = new SqlCommand(price, obj.con);
                String s1 = (String)cmd.ExecuteScalar();
                obj.con.Close();
                return s1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
                return "";
            }
        }

        public static String fetch_book_number(String bname)
        {
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String data = "select book_id from book_info where book_name= '"+bname+"'";
                SqlCommand cmd = new SqlCommand(data, obj.con);
                String s1 = (String)cmd.ExecuteScalar();
                obj.con.Close();
                return s1;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
                return "";
            }
        }

        public static void inser_data(String name,String book_num)
        {
            try
            {
                //MessageBox.Show("" + user_mail.Text + " - " + user_mail.Text.Length);
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                String insertdata = "insert into add_to_cart values('" + "" + (ImpValues.uname) + "','" + "" + (book_num) + "')";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insertdata;
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Added In Cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Logo l = new Logo();
            l.Show();
        }

        private void text_effect1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cart c = new Cart();
            c.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_programming_Click(object sender, EventArgs e)
        {
            Programming p = new Programming();
            p.Show();
            this.Hide();
        }

        private void btn_motivation_Click(object sender, EventArgs e)
        {
            Motivational_Page mp = new Motivational_Page();
            mp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Religious r = new Religious();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kids k = new Kids();
            k.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Biography b = new Biography();
            b.Show();
            this.Hide();
        }  
    }
}
