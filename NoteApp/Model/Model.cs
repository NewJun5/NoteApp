using NoteApp.Assistive;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Model
    {
        public static ListOfItem GetTestData()
        {
            var userNoteDb = new ListOfItem();

            int countNotes = 12;
            for (int i = 1; i <= countNotes; i++)
            {
                userNoteDb.CreateNote($"моя заметка{i}");
            }

            userNoteDb.CountNotes = userNoteDb.Count();
            int id = 1;
            foreach (var note in userNoteDb)
                note.Id = id++;

            return userNoteDb;
        }


        public static ListOfItem GetDataFromDb()
        {           
            string connectionString = Appsetting.GetConnectionStringToDb();
            string tableTitle = Appsetting.GetTableTitle();

            var ListOfNotes = new ListOfItem();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string sqlExp = $"SELECT * FROM {tableTitle}";
                var command = new SqlCommand(sqlExp, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string notes = (string)reader["notes"];
                        bool isDone = (bool)reader["isDone"];
                        DateTime date = (DateTime)reader["creationDate"];

                        var note = new ToDo(id, notes, isDone, date);
                        ListOfNotes.Add(note);
                    }
                }
            }
            Helper.CorrectId(ListOfNotes, 1);

            return ListOfNotes;
        }

    }
}
