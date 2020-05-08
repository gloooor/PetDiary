using PetDiary.Models;
using PetDiary.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.DataBase
{
    class PetDB
    {
        static public void AddPet(string Name, string Breed, int Age, string Sex, string Date, bool Insured, bool Desexed, string Type, int OwnerId)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "insert into [dbPet] ([Name], [Breed], [Age], [Sex], [DateOfBirth], [Insured], [Desexed], " +
                    "[Type], [OwnerId]) values (@name, @breed, @age, @sex, @date, @insured, @desexed, @type, @ownerid);";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@name", Name);
                cmd_Command.Parameters.AddWithValue("@breed", Breed);
                cmd_Command.Parameters.AddWithValue("@age", Age);
                cmd_Command.Parameters.AddWithValue("@sex", Sex);
                cmd_Command.Parameters.AddWithValue("@date", Date);
                cmd_Command.Parameters.AddWithValue("@insured", Insured);
                cmd_Command.Parameters.AddWithValue("@desexed", Desexed);
                cmd_Command.Parameters.AddWithValue("@type", Type);
                cmd_Command.Parameters.AddWithValue("@ownerid", OwnerId);
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

        static public void DeletePetById(int petId)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "delete from [dbPet] where Id=@id;";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@id", petId);
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
        static public List<Pet> GetPetsByUserId(int Id)
        {
            
            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT * FROM dbPet WHERE OwnerID=@Id";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                var list = new List<Pet>();
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Pet((int)rdr["Id"], (string)rdr["Type"], (int)rdr["Age"], (string)rdr["Name"], (string)rdr["Sex"],
                        (bool)rdr["Desexed"], (bool)rdr["Insured"], (string)rdr["Breed"], rdr["DateOfBirth"].ToString(), (int)rdr["OwnerId"]));
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
