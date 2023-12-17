using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load() 
        {
            Console.Clear();
            Console.WriteLine("Gestão de tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tag");
            Console.WriteLine("3 - Atualizar tag");
            Console.WriteLine("4 - Excluir tag");
            Console.WriteLine("5 - Menu principal");
            Console.WriteLine();
            Console.WriteLine();
            var option = Console.ReadLine();
            
            if(option == "")
            {
                MenuScreen.Load();
            }

            var wsl = short.Parse(option);
            switch (wsl)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    MenuScreen.Load(); break;
            }
        }
    }
}
