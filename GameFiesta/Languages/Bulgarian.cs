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
        public List<string> HangmanWords => new List<string>()
        {
            "Програмист",
            "Училище",
            "История",
            "Самолет",
            "ГитХъб",
            "Компютър",
            "Слон",
            "Гадже",
            "Микрофон",
            "Град",
            "Капибара",
            "Птицечовка",
            "Футбол",
            "Пинг понг",
            "Волейбол",
            "Шах",
            "Книга",
            "Империя",
            "Гира",
            "Кораб",
            "Къща",
            "Маймуна",
            "Принцип",
            "Модел",
            "Камък",
            "Ножица",
            "Пистолет",
            "Змия",
            "Браузър",
            "Състезание",
            "Риба",
            "Държава",
            "Континент",
            "Град",
            "Каубой",
            "Пиле",
            "Ресторант",
            "Магистрала",
            "Нощ",
            "Магьосник",
            "Гущер",
            "Врабче",
            "Хамелеон",
            "Муха",
            "Жираф",
            "Носорог",
            "Камион",
            "Полиция",
            "Огън",
            "Гроб"
        };

        public void PrintBackMessage()
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[underline red]Натиснете бутона изтрий ако иската да се върнете в настройките.[/]"));
            Console.WriteLine();
        }

        public void PrintContinueMessage()
        {
            AnsiConsole.Write(new Markup("[underline blue]Натиснете бутона въведи ако искате да продължите.[/]"));
            Console.WriteLine();
        }

        public void PrintLanguageChooseMessage()
        {
            AnsiConsole.Write(new Markup("[red]Натиснете бутона на клавиатурата си, който е пред играта, която искате да започнете.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [white]Бъл[/][green]гар[/][red]ски[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [red]Анг[/][white]лий[/][blue]ски[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [grey19]Не[/][red]мс[/][yellow]ки[/]"));
            Console.WriteLine();
        }

        public void PrintSetUpMessage()
        {
            AnsiConsole.Write(new Markup("[underline deeppink4]За да изберете нещо, натиснете бутона на клавиатурата си, който е пред съответната настройка.[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/][hotpink2]Избери език[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/][violet]Прочети правилата[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/][mediumorchid1]Продължи[/]"));
            Console.WriteLine();
        }

        public void PrintGameMenu()
        {
            AnsiConsole.Write(new Markup("[cornflowerblue]Щракнете върху бутона на вашата клавиатура, който е същият пред играта, която искате да играете\r\n[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[seagreen2]Избери игра:[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]1.[/] [blue]Бикове[/] И [red]Крави[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]2.[/] [gray]Бесеница[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]3.[/] [khaki1]Морски Шах[/]"));
            Console.WriteLine();
        }

        public void PrintCowsAndBullsHeader()
        {
            AnsiConsole.Write(new FigletText("Bikove i Kravi").Centered().Color(Color.Cyan1));
        }

        public void PrintCowsAndBullsInputMessage()
        {
            AnsiConsole.Write(new Markup("[blue]Напиши своето предположение: [/]"));
        }

        public void PrintCowsAndBullsOutputMessage(int bulls, int cows)
        {
            AnsiConsole.Write(new Markup($"[blue]Ти имаш:[/] [red]{bulls}Б, {cows}К[/]"));
        }

        public void PrintCowsAndBullsWinningMessage(int tryes, string correctCombination)
        {
            AnsiConsole.Write(new Markup($"[yellow]Числото беше: {correctCombination}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]Ти позна![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Ти пробва: {tryes} пъти.[/]"));
            Console.WriteLine();
        }

        public void PrintHangmanHeader()
        {
            AnsiConsole.Write(new FigletText("Besenitsa").Centered().Color(Color.DarkCyan));
        }

        public void PrintHangmanDiscoveredMessage()
        {
            AnsiConsole.Write(new Markup("[lime]Познатите букви са:[/]"));
        }

        public void PrintHangmanWrongLettersMessage(List<char> alreadyUsedLetters)
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[green]Ти използва тези грешни букви:[/] [lime]{string.Join(", ", alreadyUsedLetters)}[/]"));
        }

        public void PrintHangmanInputMessage()
        {
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[palegreen3_1]Напиши възможна буква: [/]"));
        }

        public void PrintHangmanWinningMessage(string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[yellow]ПОЗДРАВЛЕНИЯ, Ти позна думата![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Думата беше: {word}[/]"));
        }

        public void PrintHangmanLoseMessage(string hangman, string word)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup($"[yellow]{hangman}[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow]О не, ти не позна думата![/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Думата беше {word}[/]"));
        }

        public void PrintHangmanMisstakesMessage(int misstakes)
        {
            Console.WriteLine();
            AnsiConsole.Write(new Markup($"[yellow]Ти направи: {misstakes} грешки[/]"));
            Console.WriteLine();
        }

        public void PrintTikTakToeHeader()
        {
            AnsiConsole.Write(new FigletText("Morski shah").Centered().Color(Color.Gold3));
        }

        public void PrintTikTakToePlayer1Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]Името на играч 1 е: [/]"));
        }

        public void PrintTikTakToePlayer2Message()
        {
            AnsiConsole.Write(new Markup("[yellow3]Името на играч 2 е: [/]"));
        }

        public void PrintTikTakToeInputMessage(string playerName)
        {
            AnsiConsole.Write(new Markup($"[greenyellow]{playerName}, Въведете координатите на следващия си ход (формат: ред, колона): [/]"));
        }

        public void PrintTikTakToeWrongCoordinatesMessage()
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("[red]Грешни координати[/]"));
        }

        public void PrintTikTakToeDrawMessage()
        {
            AnsiConsole.Write(new Markup("[yellow]Равенство![/]"));
        }

        public void PrintTikTakToeWinningMessage(string winner)
        {
            AnsiConsole.Write(new Markup($"[yellow2]{winner} победи!!![/]"));
        }

        public void PrintErrorMessage()
        {
            AnsiConsole.Write(new Markup("[red]Грешен бутон![/]"));
            Console.WriteLine();
        }

        public void PrintRules()
        {
            AnsiConsole.Write(new Markup("[bold yellow3]Бикове и Крави[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[darkolivegreen3_2]Компютъра генерира случайна комбинация от четири числа(гарантирано е, че числата не се повтарят) " +
                Environment.NewLine +
                "и твоята цел е да познаеш комбинацията. Имаш неограничен брой опити. Ако имаш число в твоята комбинация, която се среща и при тази на компютъра, " +
                Environment.NewLine +
                "но не е на точната позиция, то ти имаш Крава, а ако имаш число, което е на точната позиция, то имаш Бик.[/]"));
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold darkviolet_1]Бесеница[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[purple_2]Компютъра генерира случайна дума и твоята цел е да я познаеш. Със всяка грешка, компютъра чертае бесилото ти " +
                Environment.NewLine +
                "и при последната ти 9 грешка, ти губиш. Как да познаеш думата? Това става като пишеш дадена буква и компютъра съответно ще ти покаже дали тази буква я има в думата или не " +
                Environment.NewLine +
                "и така трябва да познаеш думата буква по буква.[/]"));
            Console.WriteLine();
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[bold gold3]Морски шах[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[yellow3_1]Това е игра за двама играчи. Единия играе с X, а другия с O. Целта е един от двамата да има три еднакви фигури на ред, колона или диагонално.[/]"));
            Console.WriteLine();    
        }
    }
}
