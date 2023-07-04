using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineBookStore.Admin
{
    public partial class BookInfo : UserControl
    {
        String book_name;
        String author_name;
        String book_price;
        String book_id;

        public BookInfo()
        {
            InitializeComponent();
        }

        public void set_book_name(String name)
        {
            lbl_book_name.Text = name;
            book_name = name;
        }

        public void set_author_name(String name)
        {
            lbl_author_name.Text = name;
            author_name = name;
        }

        public void set_book_price(String price)
        {
            lbl_book_price.Text = "Rs. " + price;
            book_price = price;
        }

        public void set_book_id(String id)
        {
            book_id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment b = new Payment();
            b.getData(book_id,book_name,book_price);
            b.ShowDialog();
            b.Dispose();
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            String q = "insert into add_to_cart values('" + ImpValues.uname + "','" + this.book_id + "')";
            Connect c = new Connect();
            c.con.ConnectionString = c.locate;
            c.con.Open();
            SqlCommand cmd = new SqlCommand(q, c.con);
            cmd.ExecuteNonQuery();
            c.con.Close();
            MessageBox.Show("Added to cart");
        }
    }
}
