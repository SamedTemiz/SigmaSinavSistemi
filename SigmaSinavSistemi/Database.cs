using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SigmaSinavSistemi
{
    public class Database
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public void Baglan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-4KG79CQ\\SQLEXPRESS;Initial Catalog=SigmaSinav;Integrated Security=True");
        }
    }
}
