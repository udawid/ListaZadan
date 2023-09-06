using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class DbHelper
    {
        public static List<User> LoadUsers()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<User>("SELECT * FROM User", new DynamicParameters()).ToList();
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO User (Id, Imie, Login, Haslo) VALUES ('{user.Id}','{user.Imie}', '{user.Login}', '{user.Haslo}')");
            }
        }

        public static List<TodoTask> ZaladujZadania(string userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<TodoTask>($"SELECT * FROM TodoTask WHERE UserId = '{userId}'", new DynamicParameters()).ToList();
            }
        }

        public static void ZapiszZadania(List<TodoTask> tasks, string userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                foreach (TodoTask task in tasks)
                {
                    cnn.Execute($"INSERT INTO TodoTask (UserId, Title, Description, IsFinished) VALUES ('{userId}','{task.Title}','{task.Description}', {task.IsFinished})");
                }
            }
        }

        public static void UsunZadania(TodoTask task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                    cnn.Execute($"DELETE FROM TodoTask WHERE Id = {task.Id}");
               
            }
        }


        public static void ZapiszZadanie(TodoTask task, string userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                    cnn.Execute($"INSERT INTO TodoTask (UserId, Title, Description, IsFinished) VALUES ('{userId}','{task.Title}','{task.Description}', {task.IsFinished})");
            }
        }


        private static string LoadConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
