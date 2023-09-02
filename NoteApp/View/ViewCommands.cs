using NoteApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{

    public class ViewCommands
    {
        public static void ViewCommandMainMenu()
        {
            Console.WriteLine();
            foreach (var command in Enum.GetValues(typeof(Enum_CommandsMainMenu)))
                Console.WriteLine($"[{(int)command}] {command.ToString().Replace("_", " ")}");
            Console.WriteLine();
        }

        public static void ViewCommandForEdit()
        {
            Console.WriteLine();
            foreach (var command in Enum.GetValues(typeof(Enum_CommandsForEditNote)))
                Console.WriteLine($"[{(int)command}] {command.ToString().Replace("_", " ")}");
            Console.WriteLine();
        }
    }
}
