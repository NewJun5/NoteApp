using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Assistive;

namespace NoteApp.Command
{
    public class Command_DeleteAllNotes : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_DeleteAllNotes(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {
            ListOfNotes.DeleteAllNotes();
            Notification.SuccessfulAction("Ваш список заметок пуст!");
            Console.WriteLine();
        }
    }
}
