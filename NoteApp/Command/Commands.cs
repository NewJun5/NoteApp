using NoteApp.Assistive;

namespace NoteApp.Command
{
    public class Commands
    {
        public static int AcceptCommand(string nameMenu, List<int> listAvailableCommands)
        {
            Console.Write($"Введите номер {nameMenu} команды: ");
            int command = Checking.ToCheckEnteredStrCommand(Console.ReadLine(), listAvailableCommands);

            return command;
        }

        public static void ExecuteCommands_Main(ListOfItem userNotes, int command) 
        {
            switch ((Enum_CommandsMainMenu)command)
            {
                case Enum_CommandsMainMenu.CREATE_note:

                    var com = new Command_CreateNote(userNotes);
                    new Command.Invoker().Invoke(com);
                    break;

                case Enum_CommandsMainMenu.VIEW_note:
                    new Command.Invoker().Invoke(new Command.Command_ViewNote(userNotes));
                    break;

                case Enum_CommandsMainMenu.VIEW_all_notes:
                    var viewAllNotes = new Command.Command_ViewAllNotes(userNotes);
                    new Command.Invoker().Invoke(viewAllNotes);
                    break;
                case Enum_CommandsMainMenu.EDIT_note:
                    var editNoteCommand = new Command.Command_EditNote(userNotes);
                    new Command.Invoker().Invoke(editNoteCommand);
                    break;

                case Enum_CommandsMainMenu.DELETE_note:
                    var deleteNoteCommand = new Command.Command_DeleteNote(userNotes);
                    new Command.Invoker().Invoke(deleteNoteCommand);
                    break;

                case Enum_CommandsMainMenu.DELETE_all_notes:
                    var deleteAllNoteCommand = new Command.Command_DeleteAllNotes(userNotes);
                    new Command.Invoker().Invoke(deleteAllNoteCommand);
                    break;

                case Enum_CommandsMainMenu.SAVE:
                    new Command.Invoker().Invoke(new Command.Command_Save(userNotes));
                    break;

                case Enum_CommandsMainMenu.EXIT:
                    new Command.Invoker().Invoke(new Command.Command_Exit());
                    break;

                default:
                    break;
            }
        }

        public static void ExecuteCommands_ForEditNote(ToDo note, int command) 
        {
            switch ((Enum_CommandsForEditNote)command)
            {
                case Enum_CommandsForEditNote.EDIT_text_note:

                    var com = new Command_EditNotesText(note);
                    new Command.Invoker().Invoke(com);
                    break;

                case Enum_CommandsForEditNote.EDIT_status_note:
                    new Command.Invoker().Invoke(new Command.Command_EditNotesStatus(note));
                    break;

                case Enum_CommandsForEditNote.BACK:
                    new Command.Invoker().Invoke(new Command.Command_Back());
                    break;

                default:
                    break;
            }
        }
    }
}
