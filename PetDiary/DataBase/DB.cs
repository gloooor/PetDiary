using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary
{
    public class DB
    {
        static string connectionString;
        public static SqlConnection ConnectDB()
        {
            SqlConnection cn;
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            cn = new SqlConnection(connectionString);
            if (cn.State != ConnectionState.Open) cn.Open();
            return cn;
        }
        public static DataTable GetDB(string query)
        {
            SqlConnection cn = ConnectDB();
            DataTable res = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            adapter.Fill(res);
            return res;
        }

        public static void Close_DB_Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; ;
            SqlConnection cn = new SqlConnection(connectionString);
            if (cn.State != ConnectionState.Closed) cn.Close();
        }

        public static string Hash(string input)
        {
            byte[] hash = Encoding.ASCII.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string output = "";
            foreach (var b in hashenc)
            {
                output += b.ToString("x2");
            }
            return output;
        }
    }
}
