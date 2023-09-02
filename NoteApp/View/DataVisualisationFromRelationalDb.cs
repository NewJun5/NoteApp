using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using View;

namespace NoteApp
{
    public class DataVisualisationFromRelationalDb<T>
    {
        static Type classType { get; set; }
        public List<string> classProperties = new List<string>();
        public List<string[]> DateForImage = new List<string[]>();
        

        public DataVisualisationFromRelationalDb()
        {
            classType = typeof(T);

            GetPropertiesFromClass(classType);
        }

        public void GetPropertiesFromClass(Type classType)
        {
            foreach (PropertyInfo prop in classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                classProperties.Add(prop.Name.ToString());
            }
        }

        public void Option(params string[] nameColumnsForView)
        {
            foreach (var column in nameColumnsForView)
            {
                if (!classProperties.Contains(column))
                {
                    new Exception($"classProperties of class {classType} doesn't contain {column}");
                }
            }

            classProperties = nameColumnsForView.ToList();
        }

        public List<string[]> LoadingData(List<T> listInstanceOfClass)
        {
            var listData = new List<string[]>();

            foreach (var classInstance in listInstanceOfClass)
            {
                var dataRow = new string[classProperties.Count];

                for (int i = 0; i < classProperties.Count; i++)
                {
                    dataRow[i] = classType.GetProperty(classProperties[i])?.GetValue(classInstance).ToString();
                }
                listData.Add(dataRow);
            }

            return listData;
        }

        public void PreparationOfDataForView(List<T> listInstanceOfClass)
        {
            DateForImage.Add(classProperties.ToArray());
            DateForImage.AddRange(LoadingData(listInstanceOfClass));
            TableFormat.Сonfigure(classProperties.ToArray(), DateForImage, 30);
        }
        

        public void View(List<T> listInstanceOfClass)
        {
            PreparationOfDataForView(listInstanceOfClass);

            Console.WriteLine(TableFormat.Line);

            for (int i = 0; i < DateForImage.Count; i++)
            {
                Console.WriteLine(TableFormat.GetRow(DateForImage[i]));
            }
        }

        public void View(T instanceOfClass)
        {
            PreparationOfDataForView(new List<T>() { instanceOfClass });

            Console.WriteLine(TableFormat.Line);

            for (int i = 0; i < DateForImage.Count; i++)
            {
                Console.WriteLine(TableFormat.GetRow(DateForImage[i]));
            }

        }
    }
}
