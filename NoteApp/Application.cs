using System;
using NoteApp.Command;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Application
    {
        static ListOfItem UserNotes { get; set; }

        public static void Run()
        {
            UserNotes = new ListOfItem();
            SettingApp();
            StartExecutingCommand();
        }

        public static void SettingApp()
        {
            UserNotes = UploadingDataFromDb();
        }

        public static void StartExecutingCommand()
        {
            var workWithMainMenu = new Command_ExecutionMenuCommands_Main(UserNotes);
            new Command.Invoker().Invoke(workWithMainMenu);
        }

        public static ListOfItem UploadingDataFromDb()
        {
            return Model.GetDataFromDb();
        }
    }

}
