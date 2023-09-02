using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NoteApp
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Notes { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreateAt { get; set; }

        public ToDo(string someNote = "Text note")
        {
            Notes = someNote;
            IsDone = false;
            CreateAt = DateTime.Now;
        }

        public ToDo(int id, string notes, bool isDone, DateTime date)
        {
            Id = id;
            Notes = notes;
            IsDone = isDone;
            CreateAt = date;
        }
    }
}
