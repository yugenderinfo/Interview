using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    class Connection
    {
        private static Connection obj = null;
        private static readonly object mylockobject = new object();
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        public Connection()
        {

        }
        public static Connection getInstance()
        {
            lock (mylockobject)
            {
                if (obj == null)
                {
                    obj = new Connection();
                }

            }

            return obj;
        }

        public static SqlConnection connect()
        {
            string s = ConfigurationManager.ConnectionStrings["DataConnection"].ConnectionString;


            SqlConnection con = new SqlConnection(s);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
            return con;

        }
        public DataTable Selectall(string query)
        {
            da = new SqlDataAdapter(query, Connection.connect());
            dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public bool DML(string query)
        {
            cmd = new SqlCommand(query, Connection.connect());
            int x = cmd.ExecuteNonQuery();
            if (x == 1)
            {
                return true;

            }
            else
            {
                return false;

            }



        }

    }
}
