using NoteApp.Assistive;
using NoteApp.View;

namespace NoteApp.Command
{
    public class Command_ViewNote : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_ViewNote(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {
            if (ListOfNotes.GetListNotes().Count == 0)
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
                    new DataVisualisation<ToDo>().View(note);
                }
                Console.WriteLine();
            }
            
            
            
        }
    }
}
