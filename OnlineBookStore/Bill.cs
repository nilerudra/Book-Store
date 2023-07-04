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
    public partial class Bill : Form
    {
        String book_id, book_price;

        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            textBox2.Text = book_id;
            textBox3.Text = book_price;
            textBox5.Text = ImpValues.uname;
            textBox6.Text = ImpValues.user_id;
            textBox7.Text = ImpValues.user_add;
        }

        public void getData(String id, String name, String price)
        {
            book_id = id;
            book_price = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bill Saved Successfully..!");
            Home_page hm = new Home_page();
            hm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
