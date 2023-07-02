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
    public partial class Programming : Form
    {
        DataTable dt = ImpValues.getBookInfo("Programming");
        public Programming()
        {
            InitializeComponent();
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

        private void Programming_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Admin.BookInfo b = new Admin.BookInfo();
                b.set_book_name(dt.Rows[i].ItemArray[1].ToString());
                b.set_author_name(dt.Rows[i].ItemArray[5].ToString());
                b.set_book_price(dt.Rows[i].ItemArray[2].ToString());
                b.set_book_id(dt.Rows[i].ItemArray[0].ToString());
                flp.Controls.Add(b);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Home_page hm = new Home_page();
            hm.Show();
            this.Hide();
        }


        
    }
}
