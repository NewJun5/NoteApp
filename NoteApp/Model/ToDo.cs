using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
