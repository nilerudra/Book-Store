using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OnlineBookStore
{
    class ImpValues
    {
        public static String uname;
        public static String mail;
        public static String user_id;
        public static String book_price = "";
        public static String book_id = "";
        public static String user_add = "";

        /*public static int getTotalBooks(string book_type)
        {
            Connect c = new Connect();
            c.con.ConnectionString = c.locate;
            c.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from book_info where book_type = '" +book_type+ "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.con.Close();

            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }*/

        public static DataTable getBookInfo(string book_type)
        {
            Connect c = new Connect();
            c.con.ConnectionString = c.locate;
            c.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from book_info where book_type = '" +book_type+ "' and book_quntity > 0", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.con.Close();

            return dt;
        }
    }
}
