
namespace NoteApp.Command
{
    public class Command_Exit : ICommand
    {
        public void ExecuteAction()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Работа приложения завершена!");
        }
    }
}
