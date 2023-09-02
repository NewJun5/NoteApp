using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Assistive
{
    public static class Notification
    {
        public static void Attention(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Attention: {message}");
            Console.ResetColor();
        }

        public static void SuccessfulAction(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Successful operation: {message}");
            Console.ResetColor();
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warning: {message}");
            Console.ResetColor();
        }

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Info: {message}");
            Console.ResetColor();
        }

    }
}
