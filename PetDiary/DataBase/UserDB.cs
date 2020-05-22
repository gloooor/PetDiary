using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.DataBase
{
    public class UserDB
    {
        public static bool AddUser(string Login, string Password)
        {

            try
            {
                var sqlCon = DB.ConnectDB();
                if (sqlCon.State == System.Data.ConnectionState.Closed) sqlCon.Open();

                String query = "insert into dbUser (Login, Password) values (@Login, @Password)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Login", Login);
                sqlCmd.Parameters.AddWithValue("@Password", Convert.ToString(DB.Hash(Password)));
                sqlCmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                DB.Close_DB_Connection();
            }

        }
        public static User GetUserByLogin(string login)
        {

            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT TOP(1) * FROM dbUser WHERE Login=@Login";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Login", login);

                using (var rdr = sqlCmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        return new User
                        {
                           Login = rdr["Login"].ToString(),
                            Id = (int)rdr["Id"],
                            Password = rdr["Password"].ToString()
                        };
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DB.Close_DB_Connection();
            }
        }

    }
}
