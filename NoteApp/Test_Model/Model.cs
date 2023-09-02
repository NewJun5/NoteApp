using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Model
    {
        public static ListOfItem GetDataFromDb()
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

    }
}
