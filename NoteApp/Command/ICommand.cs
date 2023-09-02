using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Command
{
    public interface ICommand
    {
        void ExecuteAction();
    }
}
