using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Command
{
    public class Command_ExecutionMenuCommands_Main : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }
        public int CommandCurrent { get; set; }
        public List<int> ListIntCommands { get; set; }
        public int ExitCommand { get; set; }


        public Command_ExecutionMenuCommands_Main(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void SetMenuCommands()
        {
            ListIntCommands = Enum.GetValues(typeof(Enum_CommandsMainMenu)).Cast<Enum_CommandsMainMenu>().Select(v => (int)v).ToList();
            ExitCommand = (int)Enum_CommandsMainMenu.EXIT;
        }

        public void ExecuteAction()
        {
            SetMenuCommands();
            CommandCurrent = 0;
            ViewCommands.ViewCommandMainMenu();

            while (ExitCommand != CommandCurrent)
            {
                CommandCurrent = Commands.AcceptCommand(ListIntCommands);
                Commands.ExecuteCommands_Main(ListOfNotes, CommandCurrent);
            }

        }

    }
}
