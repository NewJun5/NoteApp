using NoteApp.Assistive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Command
{
    public class Command_EditNote : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }       

        public Command_EditNote(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {
            if (ListOfNotes.Count == 0)
                Notification.Info("Вас список заметок пуст!");
            else 
            {
                Console.Write("Введите номер заметки: ");

                int numberNote = Checking.ToCheckEnteredStrCommand(Console.ReadLine());
                ToDo note = ListOfNotes.GetNote(numberNote);

                if (note == null)
                    Notification.Attention("Заметки с таким номером не существует");
                else
                {
                    Console.WriteLine($"Заметка под номером № {numberNote}: ");
                    new DataVisualisationFromRelationalDb<ToDo>().View(note);

                    var workWithEditNoteMenu = new Command_WorkWithEditNoteMenu(note);
                    new Command.Invoker().Invoke(workWithEditNoteMenu);      
                }
                Console.WriteLine();

            }

        }
    }
}
