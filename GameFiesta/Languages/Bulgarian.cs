using GameFiesta.Languages.Contracts;
using GameFiesta.Managers;
using GameFiesta.StartScreen.Components;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Languages
{
    public class Bulgarian : ILanguage
    {
        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Натиснете бутона изтрий ако иската да се върнете в настройките.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline blue]Натиснете бутона въведи ако искате да продължите.[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintLanguageChooseMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[red]Натиснете бутона на клавиатурата си, който е пред играта, която искате да започнете.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Бъл[/][green]гар[/][red]ски[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Анг[/][white]лий[/][blue]ски[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]Не[/][red]мс[/][yellow]ки[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintSetUpMessage()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[underline deeppink4]За да изберете нещо, натиснете бутона на клавиатурата си, който е пред съответната настройка.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Избери език[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Прочети правилата[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Продължи[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }

        public void PrintGameMenu()
        {
            Logo.PrintLogo();
            AnsiConsole.Write(new Markup("[seagreen2]Избери игра:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Бикове[/] И [red]Крави[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Бесеница[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [darkgreen]Лабиринти[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]4.[/] [lime]Змив[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]5.[/] [khaki1]Морски Шах[/]"));
            Console.WriteLine();
            Footer.PrintFooter();
        }
    }
}
