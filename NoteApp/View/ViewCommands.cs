using NoteApp.Command;

namespace NoteApp.View
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
