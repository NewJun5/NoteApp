using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
