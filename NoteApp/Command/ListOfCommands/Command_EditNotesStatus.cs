using NoteApp.View;

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
            new DataVisualisation<ToDo>().View(Note);
            Console.WriteLine();
        }
    }
}
