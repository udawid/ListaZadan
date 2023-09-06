using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class TodoTaskManager
    {
        private List<TodoTask> _wszystkieZadania;

        public TodoTaskManager()
        {
            _wszystkieZadania = new List<TodoTask>();
        }

        public TodoTask ZnajdzZadanie(int id)
        {
            foreach (TodoTask zadanie in _wszystkieZadania)
            {
                if(zadanie.Id == id)
                {
                    return zadanie;
                }
            }

            return null;
        }

        public void DodaZadanie(TodoTask zadanie)
        {
            _wszystkieZadania.Add(zadanie);
            DbHelper.ZapiszZadanie(zadanie, zadanie.UserId);
            //AktualizujZadaniaUzytkownika(zadanie.UserId);
        }

        public void UsunZadanie(int id)
        {
            TodoTask task = ZnajdzZadanie(id);
            _wszystkieZadania.Remove(task);
            //AktualizujZadaniaUzytkownika(task.UserId);
            DbHelper.UsunZadania(task);
        }

        public List<TodoTask> PobierzZadania(string userId)
        {
            List<TodoTask> zadaniaZalogowanego = new List<TodoTask>();
            foreach (TodoTask zadanie in _wszystkieZadania)
            {
                if (zadanie.UserId == userId)
                {
                    zadaniaZalogowanego.Add(zadanie);
                }
            }

            return zadaniaZalogowanego;
        }

        public long ObliczNastepneId()
        {
            long max = 0;
            foreach (TodoTask zadanie in _wszystkieZadania)
            {
                if(zadanie.Id > max)
                {
                    max = zadanie.Id;
                }
            }

            return max + 1;
        }

        public void ZaladujZadaniaUzytkownika(string userId)
        {
            //_wszystkieZadania = FileHelper.ZaladujZadania(userId);\
            _wszystkieZadania = DbHelper.ZaladujZadania(userId);
        }

        public void AktualizujZadaniaUzytkownika(string userId)
        {
            DbHelper.ZapiszZadania(_wszystkieZadania, userId);
            //FileHelper.ZapiszZadania(_wszystkieZadania, userId);
        }
    }
}
