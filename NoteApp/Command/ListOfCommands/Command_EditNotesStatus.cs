using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Command
{
    public class Command_EditNotesStatus : ICommand // шляпа
    {
        public ToDo Note { get; set; }

        public Command_EditNotesStatus(ToDo note)
        {
            Note = note;
        }

        public void ExecuteAction()
        {
            Note.IsDone = !Note.IsDone;
            Console.WriteLine("Статус заметки изменен!");
            new DataVisualisationFromRelationalDb<ToDo>().View(Note);
            Console.WriteLine();
        }
    }
}
