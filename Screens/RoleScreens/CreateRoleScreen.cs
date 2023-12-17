using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Role");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome");
            var name = Console.ReadLine();
            Console.WriteLine("Slug");
            var slug = Console.ReadLine();
            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(DataBase.Connection);
                repository.Create(role);
                Console.WriteLine("Role cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel salvar a role");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
