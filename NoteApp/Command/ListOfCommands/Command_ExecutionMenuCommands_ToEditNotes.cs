using NoteApp.View;

namespace NoteApp.Command
{
    public class Command_WorkWithEditNoteMenu : ICommand
    {
        public ToDo Note { get; set; }
        public int CommandCurrent { get; set; }
        public List<int> ListIntCommands { get; set; }
        public int ExitCommand { get; set; }


        public Command_WorkWithEditNoteMenu(ToDo note)
        {
            Note = note;
        }

        public void SetMenuCommands()
        {
            ListIntCommands = Enum.GetValues(typeof(Enum_CommandsForEditNote)).Cast<Enum_CommandsForEditNote>().Select(v => (int)v).ToList();
            ExitCommand = (int)Enum_CommandsForEditNote.BACK;
        }

        public void ExecuteAction()
        {
            SetMenuCommands();
            CommandCurrent = 0;
            ViewCommands.ViewCommandForEdit();

            while (ExitCommand != CommandCurrent)
            {
                CommandCurrent = Commands.AcceptCommand("EDIT_NOTE_MENU", ListIntCommands);                
                Commands.ExecuteCommands_ForEditNote(Note, CommandCurrent);
            }

        }
    }
}
