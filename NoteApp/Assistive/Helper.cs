using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Assistive
{
    public static class Helper
    {
        public static void CorrectId(List<ToDo> listOfNotes, int numberNote)
        {
            for (int i = numberNote - 1; i < listOfNotes.Count; i++)
            {
                listOfNotes[i].Id = numberNote++;
            }
        }
    }
}
