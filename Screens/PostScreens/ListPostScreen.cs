using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de posts");
            Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Post>(DataBase.Connection);
            var posts = repository.Get();

            foreach (var item in posts)
                Console.WriteLine($"{item.Id} - {item.Title} ({item.Slug})");


        }
    }
}
