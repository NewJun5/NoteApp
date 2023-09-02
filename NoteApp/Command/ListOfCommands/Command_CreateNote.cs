using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Assistive;

namespace NoteApp.Command
{
    public class Command_CreateNote : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_CreateNote(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {           
            Console.WriteLine("Введите текст заметки: ");
            ListOfNotes.CreateNote(Console.ReadLine());

            if (ListOfNotes.Count < ListOfNotes.MaxCountNotes)
            {
                ToDo note = ListOfNotes.GetNote(ListOfNotes.Count);
                new DataVisualisationFromRelationalDb<ToDo>().View(note);

                Notification.SuccessfulAction("Заметка успешно добавлена!");

                if (ListOfNotes.Count > 10)
                    Notification.Attention("Количество ваших заметок приближается к максимуму");
                Console.WriteLine();
            }
            else
                throw new Exception("В базе данных нет свободного места!");

        }
    }

    
}
