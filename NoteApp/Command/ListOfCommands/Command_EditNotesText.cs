
namespace NoteApp.Command
{
    public class Command_EditNotesText : ICommand // шляпа
    {
        public ToDo Note { get; set; }

        public Command_EditNotesText(ToDo note)
        {
            Note = note;
        }

        public void ExecuteAction()
        {
            Console.WriteLine("Введите новый текст заметки: ");

            Note.Notes = Console.ReadLine();

            Console.WriteLine("Текст заметки изменен!");
            new DataVisualisation<ToDo>().View(Note);
            Console.WriteLine();
        }
    }
}
