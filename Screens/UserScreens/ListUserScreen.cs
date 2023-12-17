using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista usuarios");
            Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<User>(DataBase.Connection);
            var users = repository.Get();

            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");


        }
    }
}