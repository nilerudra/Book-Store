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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void cno_Enter(object sender, EventArgs e)
        {
            if (cno.Text == "Card Number")
            {
                cno.Text = "";
                cno.ForeColor = Color.Black;
            }
        }
        private void cno_Leave(object sender, EventArgs e)
        {
            if (cno.Text == "")
            {
                cno.Text = "Card Number";
                cno.ForeColor = Color.Silver;
            }
        }

        private void upi_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void upi_id_Leave(object sender, EventArgs e)
        {
            if (upi_id.Text == "")
            {
                upi_id.Text = "UPI ID";
                upi_id.ForeColor = Color.Silver;
            }
        }

        private void upi_id_Enter(object sender, EventArgs e)
        {
            if (upi_id.Text == "UPI ID")
            {
                upi_id.Text = "";
                cno.ForeColor = Color.Black;
            }
        }

        private void cno_TextChanged(object sender, EventArgs e)
        {

        }

       

       
        private void Payment_Load(object sender, EventArgs e)
        {
            //textBox5.Text = Bill.book_price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void month_Leave(object sender, EventArgs e)
        {
            if (month.Text == "")
            {
                month.Text = "Month";
                month.ForeColor = Color.Silver;
            }
        }

        private void month_Enter(object sender, EventArgs e)
        {
            if (month.Text == "Month")
            {
                month.Text = "";
                month.ForeColor = Color.Black;
            }
        }

        private void cvv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cvv_Leave(object sender, EventArgs e)
        {
            if (cvv.Text == "")
            {
                cvv.Text = "CVV Code";
                cvv.ForeColor = Color.Silver;
            }
        }

        private void cvv_Enter(object sender, EventArgs e)
        {
            if (cvv.Text == "CVV Code")
            {
                cvv.Text = "";
                cvv.ForeColor = Color.Black;
            }
        }

        private void year_Enter(object sender, EventArgs e)
        {
            if (year.Text == "Year")
            {
                year.Text = "";
                year.ForeColor = Color.Black;
            }
        }

        private void year_Leave(object sender, EventArgs e)
        {
            if (year.Text == "")
            {
                year.Text = "Year";
                year.ForeColor = Color.Silver;
            }
        }

        internal void getData(string book_id, string book_name, string book_price)
        {
            throw new NotImplementedException();
        }
    }
}
