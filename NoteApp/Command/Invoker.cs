namespace NoteApp.Command
{
    public class Invoker
    {
        public ICommand Command { get; set; }

        public void Invoke(ICommand command)
        {
            Command = command;
            Command.ExecuteAction();
        }
    }
}
