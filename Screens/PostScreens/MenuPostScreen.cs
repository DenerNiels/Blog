using Blog.Screens.CategoryScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear(); 
            Console.WriteLine("Gestão de Posts");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar post");
            Console.WriteLine("3 - Atualizar post");
            Console.WriteLine("4 - Excluir post");
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
                    ListPostScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                case 5:
                    MenuScreen.Load(); break;
            }
        }
    }
}
