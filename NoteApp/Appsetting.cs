using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Appsetting
    {
        readonly static string ConnectionString = @"Data Source=DESKTOP-47N01LD\SQLEXPRESS; Database = notesUser_db; Trusted_Connection=True;";
        readonly static string TableTitle = "notes_db";


        //настройки для работы с SystemIO
        readonly static string DirectoryPathPC = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static string GetDirectoryPathPC()
        {
            return DirectoryPathPC;        
        }
        public static string GetConnectionStringToDb()
        {
            return ConnectionString;
        }

        public static string GetTableTitle()
        {
            return TableTitle;
        }
    }
}
