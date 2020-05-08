using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.DataBase
{
    public class UserDB
    {
        public User GetUserByFirstNameAndLastName(string firstName, string lastName)
        {

            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT TOP(1) * FROM dbUser WHERE FirstName=@Firstname AND LastName=@Lastname";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Lastname", lastName);
                sqlCmd.Parameters.AddWithValue("@Firstname", firstName);

                using (var rdr = sqlCmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        return new User
                        {
                            FirstName = rdr["FirstName"].ToString(),
                            LastName =rdr["LastName"].ToString(),
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
