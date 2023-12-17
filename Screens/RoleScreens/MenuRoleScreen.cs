using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de roles");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Listar roles");
            Console.WriteLine("2 - Cadastrar role");
            Console.WriteLine("3 - Atualizar role");
            Console.WriteLine("4 - Excluir role");
            Console.WriteLine("5 - Menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = Console.ReadLine();

            if (option == "")
            {
                MenuScreen.Load();
            }

            var wsl = short.Parse(option);
            switch (wsl)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                case 5:
                    MenuScreen.Load(); break;
            }
        }
        
    }
}
