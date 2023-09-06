using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class TodoTask
    {
        public long Id; //SqLite zamienia klucz główny na int64 dlatego musielimy użyć longa 
        public string UserId;
        public string Title;
        public string Description;
        public long IsFinished;

        public TodoTask(long Id, string UserId, string Title, string Description, long IsFinished)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.Title = Title;
            this.Description = Description;
            this.IsFinished = IsFinished;
        }
    }
}