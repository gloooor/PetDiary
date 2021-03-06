﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.DataBase
{
    class ActivityNoteDB
    {
        static public void AddNote(string Date, string Location, int Hours, int Minutes, string Comment, int Rating, int petID)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "insert into [dbActivityNote] ([Date], [Location], [Hours], [Minutes], [Comment], [Rating], [PetID]) " +
                    "values (CONVERT(date, @date), @location, @hours, @minutes, @comment, @rating, @petid);";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@date", Date.ToString());
                cmd_Command.Parameters.AddWithValue("@location", Location);
                cmd_Command.Parameters.AddWithValue("@hours", Hours);
                cmd_Command.Parameters.AddWithValue("@minutes", Minutes);
                cmd_Command.Parameters.AddWithValue("@comment", Comment);
                cmd_Command.Parameters.AddWithValue("@rating", Rating);
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
        static public void UpdateNote(int Id, string Date, string Location, int Hours, int Minutes, string Comment, int Rating)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "update [dbActivityNote] set [Date]=CONVERT(date, @date), [Location]=@location, " +
                    "[Hours]=@hours, [Minutes]= @minutes, [Comment]=@comment, [Rating]= @rating " +
                    "where Id=@id";

                SqlCommand cmd_Command = new SqlCommand(query, cn_connection);
                cmd_Command.Parameters.AddWithValue("@date", Date.ToString());
                cmd_Command.Parameters.AddWithValue("@location", Location);
                cmd_Command.Parameters.AddWithValue("@hours", Hours);
                cmd_Command.Parameters.AddWithValue("@minutes", Minutes);
                cmd_Command.Parameters.AddWithValue("@comment", Comment);
                cmd_Command.Parameters.AddWithValue("@rating", Rating);
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
        static public void DeleteNoteById(int id)
        {
            try
            {
                SqlConnection cn_connection = DB.ConnectDB();
                var query = "delete from [dbActivityNote] where Id=@id;";

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
        public List<ActivityNote> GetNotesByPetId(int Id)
        {
            try
            {
                var sqlCon = DB.ConnectDB();
                var query = "SELECT * FROM dbActivityNote WHERE PetID=@Id";
                var sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Id", Id);
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    var list = new List<ActivityNote>();
                    while (rdr.Read())
                    {
                        var date = DateTime.Parse(rdr["Date"].ToString()).ToString("dd/MM/yyyy");
                        list.Add(new ActivityNote((int)rdr["Id"], date, rdr["Location"].ToString(), (int)rdr["Hours"], (int)rdr["Minutes"],
                        rdr["Comment"].ToString(), (int)rdr["Rating"], (int)rdr["PetId"]));
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
