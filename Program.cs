
using Blog;
using Blog.Screens;
using Blog.Screens.TagScreens;
using System.Data.SqlClient;

class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

    static void Main(string[] args)
    {
        DataBase.Connection = new SqlConnection(CONNECTION_STRING);
        DataBase.Connection.Open();

        MenuScreen.Load();
  
        Console.ReadKey();
        DataBase.Connection.Close();
    } 
}