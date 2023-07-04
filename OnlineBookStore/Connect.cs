using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineBookStore
{
    class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public String locate = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADITYA RAMESH NIKAM\Documents\Final_Project\OnlineBookStore\Database1.mdf;Integrated Security=True;User Instance=True";

        //public String locate = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADITYA RAMESH NIKAM\Documents\Visual Studio 2010\Projects\Final_Project\OnlineBookStore\Database1.mdf;Integrated Security=true;User Instance=True";       

        
        //public String locate = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADITYA RAMESH NIKAM\Documents\Visual Studio 2010\Projects\Final_Project\OnlineBookStore\Database1.mdf;Integrated Security=True;User Instance=True";
        //public String locate =@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\ADITYA RAMESH NIKAM\Documents\Visual Studio 2010\Projects\OnlineBookStore\OnlineBookStore\Database1.mdf';Integrated Security=True;User Instance=True;
       //  public String locate = @" Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Suyash Bhole\Documents\Visual Studio 2010\Projects\OriginalOnlineBookStore2\OnlineBookStore\Database1.mdf;Integrated Security=True;User Instance=True";
        // public String locate = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Lenovo\Documents\Visual Studio 2010\Projects\OriginalOnlineBookStore2\OnlineBookStore\Database1.mdf;Integrated Security=True;User Instance=True";

    }
}
