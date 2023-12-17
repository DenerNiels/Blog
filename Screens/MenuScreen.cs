using Blog.Screens.CategoryScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens
{
    public class MenuScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("--------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Usuário");
            Console.WriteLine("2 - Posts");
            Console.WriteLine("3 - Categorias");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/Usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatorios");
            Console.WriteLine("Pressione ESQ para sair");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuPostScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                //case 5:
                //    MenuTagScreen.Load();
                //    break;
                //case 6:
                //    MenuTagScreen.Load();
                //    break;
                //case 7:
                //    MenuTagScreen.Load();
                //    break;
                default: Load(); break;
            }
        }
    }
}
