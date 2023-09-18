using GameFiesta.Languages.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using GameFiesta.Managers;
using GameFiesta.StartScreen.Components;

namespace GameFiesta.Languages
{
    public class English : ILanguage
    {
        //Messages used in SetUp class

        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Press delete if you want to go back to the SetUp options[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline blue]Press enter if you want to continue[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintLanguageChooseMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[red]Press the button which is equal to number before the language you want to change.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Bul[/][green]gar[/][red]ian[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Eng[/][white]li[/][blue]sh[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]Ge[/][red]rm[/][yellow]an[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintSetUpMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[underline deeppink4]If you want to change something click the button of your keyboard which is equal to the number before the setting.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Choose language[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Read Rules[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Continue[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        //End of messages used in SetUp class
        
        //Messages used in Header class
        public void PrintGameMenu()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[seagreen2]Choose game:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Cows[/] And [red]Bulls[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Hangman[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [darkgreen]Labirinths[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]4.[/] [lime]Snake[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]5.[/] [khaki1]TikTakToe[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }
        //End of messages used in Header class
    }
}
