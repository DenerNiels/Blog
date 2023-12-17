using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen  
    {
        public static void Load()
        {
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.Get();

            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");


        }
    }
}
