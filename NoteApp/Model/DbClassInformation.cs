using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.View
{
    public static class DbClassInformation<T>
    {
        public static Type ClassType = typeof(T);
        public static List<string> classProperties { get; set; }

        public static List<string> GetClassProperties()
        {
            foreach (PropertyInfo prop in ClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                classProperties.Add(prop.Name.ToString());
            }

            return classProperties;
        }
    }
}
