using NoteApp.View;
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
    public class DataVisualisation<T>
    {
        public List<string> ColumnHeading = new List<string>();
        public List<string[]> DateForImage = new List<string[]>();        

        public DataVisualisation()
        {
            ColumnHeading = DbClassInformation<ToDo>.GetClassProperties();
        }        

        public void Option(params string[] nameColumnsForView)
        {
            foreach (var column in nameColumnsForView)
            {
                if (!ColumnHeading.Contains(column))
                {
                    new Exception($"ColumnHeading of class {typeof(T)} doesn't contain {column}");
                }
            }

            ColumnHeading = nameColumnsForView.ToList();
        }

        public List<string[]> LoadingData(List<T> listInstanceOfClass)
        {
            var listData = new List<string[]>();

            foreach (var classInstance in listInstanceOfClass)
            {
                var dataRow = new string[ColumnHeading.Count];

                for (int i = 0; i < ColumnHeading.Count; i++)
                {
                    dataRow[i] = typeof(T).GetProperty(ColumnHeading[i])?.GetValue(classInstance).ToString();
                }
                listData.Add(dataRow);
            }

            return listData;
        }

        public void PreparationOfDataForView(List<T> listInstanceOfClass)
        {
            DateForImage.Add(ColumnHeading.ToArray());
            DateForImage.AddRange(LoadingData(listInstanceOfClass));
            TableFormat.Сonfigure(ColumnHeading.ToArray(), DateForImage, 30); // 30 - ограничение размера ширины колонки.
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
