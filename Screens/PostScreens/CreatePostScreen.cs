using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");

            Console.WriteLine("Nome");
            var title = Console.ReadLine();
            Console.WriteLine("Summary");
            var summary = Console.ReadLine();
            Console.WriteLine("Body");
            var body = Console.ReadLine();
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();
            Console.WriteLine("Author");
            var author = Console.ReadLine();
            Console.WriteLine("Category");
            var category = Console.ReadLine();

            //try
            //{
            //    var repository = new Repository<User>(DataBase.Connection);
            //    var user = repository.Get(author);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            
            Create(new Post
            {
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                //Author = author, 

            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(DataBase.Connection);
                repository.Create(post);
                Console.WriteLine("Post criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel criar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
