using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Save_toDb
    {
        public static string ConnectionString = Appsetting.GetConnectionStringToDb();
        public static string TableTitle = Appsetting.GetTableTitle();
        public static void SaveToDb(ListOfItem listOfNotes)
        {  
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlExp1 = $"TRUNCATE TABLE {TableTitle}";
                var command1 = new SqlCommand(sqlExp1, connection);
                command1.ExecuteNonQuery();

                var note = listOfNotes[0];
                string sqlExp2 = $"INSERT INTO {TableTitle} (notes, isDone, creationDate) VALUES ('{note.Notes}',{Convert.ToByte(note.IsDone)},'{note.CreateAt.ToString("yyyy-MM-dd HH:mm:ss.fff")}');";
                var command2 = new SqlCommand(sqlExp2, connection);
                command2.ExecuteNonQuery(); 

                /*foreach (var note in listOfNotes)
                {
                    string sqlExp2 = $"INSERT INTO {TableTitle} (id, notes, isDone, creationDate) VALUES ({note.Id},{note.Notes},{Convert.ToByte(note.IsDone)},{note.CreateAt})";
                    SqlCommand command2 = new SqlCommand(sqlExp2, connection);
                    command2.ExecuteNonQuery();                    
                }*/
            }           
        }
    }
}


/*int id = (int)reader["id"];
string notes = (string)reader["notes"];
bool isDone = (bool)reader["isDone"];
DateTime date = (DateTime)reader["creationDate"];*/