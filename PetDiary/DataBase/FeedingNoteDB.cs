using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.DataBase
{
    public class FeedingNoteDB
    {
        static public void UpdateNote(int Id, string Date, bool WetFood, bool DryFood, bool Meat, bool Medicines, bool Other)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "update [dbFeedingNote]  set [Date] = CONVERT(date, @date), [WetFood] = @wetfood," +
                    " [DryFood] = @dryfood, [Meat] = @meat, [Medicines] = @medicines, [Other] = @other where Id = @id";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@date", Date.ToString());
                cmd_Command.Parameters.AddWithValue("@wetfood", WetFood);
                cmd_Command.Parameters.AddWithValue("@dryfood", DryFood);
                cmd_Command.Parameters.AddWithValue("@meat", Meat);
                cmd_Command.Parameters.AddWithValue("@medicines", Medicines);
                cmd_Command.Parameters.AddWithValue("@other", Other);
                cmd_Command.Parameters.AddWithValue("@id", Id);
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

        static public void AddNote(string Date, bool WetFood, bool DryFood, bool Meat, bool Medicines, bool Other, int petID)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "insert into [dbFeedingNote] ([Date], [WetFood], [DryFood], [Meat], [Medicines], [Other], [PetID]) " +
                    "values (CONVERT(date, @date), @wetfood, @dryfood, @meat, @medicines, @other, @petid);";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@date", Date.ToString());
                cmd_Command.Parameters.AddWithValue("@wetfood", WetFood);
                cmd_Command.Parameters.AddWithValue("@dryfood", DryFood);
                cmd_Command.Parameters.AddWithValue("@meat", Meat);
                cmd_Command.Parameters.AddWithValue("@medicines", Medicines);
                cmd_Command.Parameters.AddWithValue("@other", Other);
                cmd_Command.Parameters.AddWithValue("@petid", petID);
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

        static public void DeleteNoteById(int id)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "delete from [dbFeedingNote] where Id=@id;";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@id", id);
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

        public List<FeedingNote> GetNotesByPetId(int Id)
        {

            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT * FROM dbFeedingNote WHERE PetID=@Id";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    var list = new List<FeedingNote>();
                    while (rdr.Read())
                    {
                        list.Add(new FeedingNote((int)rdr["Id"], rdr["Date"].ToString(), (bool)rdr["WetFood"], (bool)rdr["DryFood"], (bool)rdr["Meat"],
                        (bool)rdr["Medicines"], (bool)rdr["Other"], (int)rdr["PetId"]));
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
