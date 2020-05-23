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

                String query = "insert into dbUser (Login, Password, IaAdmin) values (@Login, @Password, 'False')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Login", Login);
                sqlCmd.Parameters.AddWithValue("@Password", Convert.ToString(Password));
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
                        return new User(rdr["Login"].ToString(), (int)rdr["Id"], rdr["Password"].ToString(), (bool)rdr["IaAdmin"]);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                DB.Close_DB_Connection();
            }
        }
        static public void UpdateUserById(int userId)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "update [dbUser] set IaAdmin = 'true'  where Id=@id;";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@id", userId);
                cmd_Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.Close_DB_Connection();
            }
        }
        static public void DeleteUserById(int userId)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "delete from [dbUser] where Id=@id;";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@id", userId);
                cmd_Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.Close_DB_Connection();
            }
        }
        static public List<User> GetUsers()
        {
            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT * FROM dbUser WHERE IaAdmin = 'False'";
                var sqlCmd = new SqlCommand(query, sqlCon);
                var list = new List<User>();
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new User((string)rdr["Login"], (int)rdr["Id"], (string)rdr["Password"], (bool)rdr["IaAdmin"]));
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                DB.Close_DB_Connection();
            }
        }
    }

}


