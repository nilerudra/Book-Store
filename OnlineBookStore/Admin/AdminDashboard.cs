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
    public partial class AdminDashboard : Form
    {
        DataTable dt = new DataTable();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dt.Clear();
            Connect c = new Connect();
            c.con.ConnectionString = c.locate;
            c.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from book_info", c.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.con.Close();
        }

        private void btn_Addbook_Click(object sender, EventArgs e)
        {

        }
    }
}
