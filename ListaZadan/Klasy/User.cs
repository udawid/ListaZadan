using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class User
    {
        public string Id;
        public string Imie;
        public string Login;
        public string Haslo;

        public User(string Id, string Imie, string Login, string Haslo)
        {
            this.Id = Id;
            this.Imie = Imie;
            this.Login = Login;
            this.Haslo = Haslo;
        }
    }
}
