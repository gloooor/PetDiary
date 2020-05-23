using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.DataBase
{
    public class StatDB
    {
        static public List<Stat> GetStatistic(int Id)
        {

            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT * FROM dbWeight WHERE PetId=@Id";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                var list = new List<Stat>();
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Stat(Convert.ToDateTime(rdr["Date"]), (double)rdr["Weight"], (int)rdr["PetId"]));
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
        static public void AddStat(DateTime Date, double Weight, int OwnerId)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "insert into [dbWeight] ([Date], [Weight], [PetId]) values" +
                    " (@number, @weight, @petid);";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@number", Date.ToString("dd/MM/yyyy"));
                cmd_Command.Parameters.AddWithValue("@weight", Weight);
                cmd_Command.Parameters.AddWithValue("@petid", OwnerId);
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

    }
}
