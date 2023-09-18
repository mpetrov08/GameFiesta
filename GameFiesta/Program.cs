using GameFiesta.enums;
using GameFiesta.Languages;
using GameFiesta.Managers;
using Spectre.Console;
using System.ComponentModel.Design;
using GameFiesta.StartScreen;

namespace GameFiesta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SetUpManager manager = new SetUpManager();
            //manager.Print();
            //var key = Console.ReadKey();
            //Console.WriteLine(key.Key);
            //var keyChar  = key.KeyChar;
            //int a = 1;

            //HeaderManager manager = new HeaderManager();
            //manager.Print();

            //English english = new English();
            //Console.WriteLine(english.SetUpMessage);

            //User user = new User();
            //user.Language.PrintLanguageChooseMessage();

            User user = new User();
            StartUpScreen start = new StartUpScreen(user);
            start.Visualize();
        }
    }
}