using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFiesta.enums;
using GameFiesta.Languages;
using GameFiesta.Managers.Contracts;
using GameFiesta.StartScreen.Components;
using Spectre.Console;

namespace GameFiesta.Managers
{
    public class SetUp : IManager
    {
        private User user;

        private SetUpOptions setUpOption;
        private Langugages language;
        private ContinueOptions continueOption;

        private List<SetUpOptions> possibleSetUpOptions;
        private List<Langugages> possibleLanguagesOptions;
        private List<ContinueOptions> possibleContinueOptions;

        private List<ConsoleKey> posibleNumbersKeys;
        private List<ConsoleKey> posibleSpecialKeys;

        public SetUp(User user)
        {
            this.user = user;


            possibleSetUpOptions = new List<SetUpOptions>
            { 
                SetUpOptions.ChangeLanguage,
                SetUpOptions.ReadRules,
                SetUpOptions.Continue
            };

            possibleLanguagesOptions = new List<Langugages>
            { 
                Langugages.Bulgarian,
                Langugages.English,
                Langugages.German
            };

            possibleContinueOptions = new List<ContinueOptions> 
            {
                ContinueOptions.Back,
                ContinueOptions.Continue 
            };


            posibleNumbersKeys = new List<ConsoleKey>
            {
                ConsoleKey.D1,
                ConsoleKey.D2,
                ConsoleKey.D3
            };

            posibleSpecialKeys = new List<ConsoleKey>
            {
                ConsoleKey.Backspace,
                ConsoleKey.Enter
            };
        }

        public void Print()
        {
            user.Language.PrintSetUpMessage();

            setUpOption = Choose.MakeChoose(possibleSetUpOptions, posibleNumbersKeys);
            if (setUpOption == SetUpOptions.Continue)
            {
                Console.Clear();
                return;
            }
            else if (setUpOption == SetUpOptions.ChangeLanguage)
            {
                Console.Clear();
                LanguageSetter();
            }
            else if (setUpOption == SetUpOptions.ReadRules)
            {
                Console.Clear();
                Logo.PrintLogo();
                PrintRules();
            }
        }

        private void LanguageSetter()
        {
            user.Language.PrintLanguageChooseMessage();
            language = Choose.MakeChoose(possibleLanguagesOptions, posibleNumbersKeys);
            Console.Clear();
            Logo.PrintLogo();
            if (language == Langugages.Bulgarian)
            {
                AnsiConsole.Write(new Markup("[white]Бъл[/][green]гар[/][red]ски[/] [darkgoldenrod] е избран като настоящ език.[/]"));
                user.Language = new Bulgarian();
            }
            else if (language == Langugages.English)
            {
                AnsiConsole.Write(new Markup("[red]Eng[/][white]li[/][blue]sh[/] [darkgoldenrod]was set as main language[/]"));
                user.Language = new English();
            }
            else if (language == Langugages.German)
            {
                AnsiConsole.Write(new Markup("[darkgoldenrod]Als Hauptsprache wurde[/] [grey19]De[/][red]ut[/][yellow]sch[/] [darkgoldenrod]eingestellt[/]"));
                user.Language = new German();
            }

            Back();
        }

        private void Back()
        {
            user.Language.PrintBackMessage();
            continueOption = Choose.MakeChoose(possibleContinueOptions, posibleSpecialKeys);
            if (continueOption == ContinueOptions.Continue)
            {
                Console.Clear();
                return;
            }
            else if (continueOption == ContinueOptions.Back)
            {
                Console.Clear();
                Print();
            }
        }

        private void PrintRules()
        {
            Console.WriteLine("Test");
            Back();
            //TODO
        }
    }
}
