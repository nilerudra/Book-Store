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
    public partial class Biography : Form
    {
        DataTable dt = ImpValues.getBookInfo("Biography");
        public Biography()
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

        private void button17_Click_1(object sender, EventArgs e)
        {
            Home_page h = new Home_page();
            h.Show();
            this.Hide();
        }

        private void Biography_Load(object sender, EventArgs e)
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
    }
}
