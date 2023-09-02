using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Assistive
{
    public static class Checking
    {
        public static int ToCheckEnteredStrCommand(string command_str)
        {
            bool condition = int.TryParse(command_str, out int command);

            while (!condition)
            {
                Notification.Warning("Проверьте корректность введенных данных!");
                Console.Write("Попробуйте ввести еще раз: ");
                condition = int.TryParse(Console.ReadLine(), out command);
            }
            return command;
        }

        public static int ToCheckEnteredStrCommand(string command_str, List<int> listAvailableCommands)
        {
            bool condition = int.TryParse(command_str, out int command) && listAvailableCommands.Contains(command);

            while (!condition)
            {
                Notification.Warning("Проверьте корректность введенных данных!");
                Console.Write("Попробуйте ввести еще раз: ");
                condition = int.TryParse(Console.ReadLine(), out command) && listAvailableCommands.Contains(command);
            }

            return command;
        }
    }
}
