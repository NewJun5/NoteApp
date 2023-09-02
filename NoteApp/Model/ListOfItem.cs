using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class ListOfItem : List<ToDo>
    {
        public int CountNotes = 0;
        public int MaxCountNotes = 15; // по условию на 15 приложение должно "упасть"!. 
        
        public void CreateNote(string? textNote)
        {  
            var newNote = new ToDo(textNote);            
            this.Add(newNote);
            newNote.Id = this.Count;
        }

        public bool DeleteNote(int numberNote)
        {  
            var isDelete = this.Remove(this.FirstOrDefault(n => n.Id == numberNote)!);
            if (isDelete) 
            {
                CountNotes--;
            }
            return isDelete;
        }

        public void DeleteAllNotes()
        {
            this.Clear();
            CountNotes = this.Count;           
        }
           

        public ToDo GetNote(int numberNote)
        {
            return this.FirstOrDefault(n => n.Id == numberNote)!;
        }

        public List<ToDo> GetListNotes()
        {
            return this;
        }
    }
}
