using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    class FileHelper
    {
        private static string _basePath = $@"{AppDomain.CurrentDomain.BaseDirectory}/data/";

        public static List<TodoTask> ZaladujZadania(string userId)
        {
            List<TodoTask> todoTasks = new List<TodoTask>();

            string filePath = $@"{_basePath}{userId}.txt";

            if(File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string linia;
                while((linia = reader.ReadLine()) != null)
                {
                    string[] columns = linia.Split('|');
                    int id = int.Parse(columns[0]);
                    string title = columns[1];
                    int isFinished = int.Parse(columns[2]);
                    string description = columns[3];
                    TodoTask task = new TodoTask(id, userId, title, description, isFinished);
                    task.IsFinished = isFinished;
                    todoTasks.Add(task);
                }
                reader.Close();
            }
            return todoTasks;
        }

        public static void ZapiszZadania(List<TodoTask> tasks, string userId)
        {
            string filePath = $@"{_basePath}{userId}.txt";
            StringBuilder builder = new StringBuilder();

            foreach (TodoTask task in tasks)
            {
                builder.AppendLine($"{task.Id}|{task.Title}|{task.IsFinished}|{task.Description}");
            }

            File.WriteAllText(filePath, builder.ToString());
        }

        public static void ZapiszUzytkownika(User user)
        {
            string filePath = $@"{_basePath}users.txt";
            string linia = $"{user.Id}|{user.Login}|{user.Imie}|{user.Haslo}{Environment.NewLine}";
            if(!Directory.Exists(_basePath))
            {
                Directory.CreateDirectory(_basePath);
            }
            File.AppendAllText(filePath, linia);
        }

        public static List<User> ZaladujUzytkownikow()
        {
            List<User> appUsers = new List<User>();
            string filePath = $@"{_basePath}users.txt";
            
            if(File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                string linia;
                while ((linia = reader.ReadLine()) != null)
                {
                    string[] columns = linia.Split('|');
                    string id = Guid.Parse(columns[0]).ToString();
                    string login = columns[1];
                    string name = columns[2];
                    string password = columns[3];
                    User user = new User(id, name, login, password);
                    appUsers.Add(user);
                }
                reader.Close();
            }
            return appUsers;
        }
    }
}
