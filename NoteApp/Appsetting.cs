using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Appsetting
    {
        readonly static string ConnectionString = @"Data Source=DESKTOP-47N01LD\\\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";

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
    }
}
