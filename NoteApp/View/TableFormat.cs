namespace NoteApp.View
{
    public class TableFormat
    {
        public static string[] Head { get; set; }
        public static int[] MaxLength { get; set; }
        public static string Line { get; set; }
        public static int MaxLenthColumn { get; set; }        

        public static void Сonfigure( string[] head, List<string[]> dataTable, int maxLenthColumn)
        {
            Head = head;
            MaxLenthColumn = maxLenthColumn;
            GetMaxLength(dataTable);            
            Line = new string('-', MaxLength.Sum() + MaxLength.Length * 5 + 1);
        }

        public static void GetMaxLength(List<string[]> data)
        {
            MaxLength = new int[Head.Length]; 

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    MaxLength[j] = Math.Max(MaxLength[j], Math.Min(data[i][j].Length, MaxLenthColumn));
                }
            }
        }

        public static string GetRow(string[] dataRow)
        {
            string row = string.Empty;

            for (int i = 0; i < dataRow.Length; i++)
            {
                string value = dataRow[i].Length > MaxLenthColumn ? dataRow[i].Substring(0, MaxLenthColumn) : dataRow[i];                
                row += $"|  {value.PadRight(MaxLength[i] + 2)}";  
            }
            return row + $"|\n{Line}";
        }
    }
}
