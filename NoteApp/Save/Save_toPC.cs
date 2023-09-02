using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Save_toPC
    {
        public static string DirectoryPathDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string DirectoryPathForSaving = Appsetting.GetDirectoryPathPC();
        public static string NameFileForRecord = "UserNotes-Json.txt";       

        public static void Record(ListOfItem listOfNotes)
        {
            string pathToFile = $@"{DirectoryPathForSaving}\{NameFileForRecord}";

            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            using (var stream = new StreamWriter(pathToFile, false))
            {
                foreach (var note in listOfNotes)
                {
                    string note_json = JsonSerializer.Serialize<ToDo>(note, options);                   
                    stream.WriteLine(note_json);
                }
            }
        }

    }

}


