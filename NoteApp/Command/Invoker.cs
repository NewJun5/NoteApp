using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
