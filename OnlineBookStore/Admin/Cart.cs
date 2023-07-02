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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home_page h = new Home_page();
            h.Show();
            this.Close();
        }

        private void text_effect1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            try
            {
                Connect c = new Connect();
                c.con.ConnectionString = c.locate;
                c.con.Open();
                String q = "SELECT book_info.book_id, book_info.book_name, book_info.book_author, book_info.book_price, book_info.book_type FROM book_info JOIN add_to_cart ON book_info.book_id = add_to_cart.book_id WHERE add_to_cart.user_id = '" + ImpValues.uname + "'";

                //string query = "select * from add_to_cart where user_id = '" + "" + (ImpValues.uname) + "'";
                SqlCommand cmd = new SqlCommand(q, c.con);
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
                c.con.Close();
            }
            catch (Exception p)
            {
                MessageBox.Show("Error " + p);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
