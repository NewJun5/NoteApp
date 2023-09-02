using NoteApp.View;

namespace NoteApp.Command
{
    public class Command_Back : ICommand
    {
        public void ExecuteAction()
        {
            ViewCommands.ViewCommandMainMenu();
        }
    
    }
}
