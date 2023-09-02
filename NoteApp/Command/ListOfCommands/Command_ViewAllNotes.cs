using NoteApp.Assistive;
using NoteApp.View;

namespace NoteApp.Command
{
    public class Command_ViewAllNotes : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_ViewAllNotes(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {
            if (ListOfNotes.Count == 0)
                Notification.Info("Вас список заметок пуст!");
            else 
            {
                new DataVisualisation<ToDo>().View(ListOfNotes);
                ViewCommands.ViewCommandMainMenu();
            }
            Console.WriteLine();            
        }
    }
}

