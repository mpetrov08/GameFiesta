using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFiesta.Managers.Contracts;
using Spectre.Console;

namespace GameFiesta.StartScreen.Components
{
    public static class Footer
    {
        public static void PrintFooter()
        {
            AnsiConsole.Write(new Markup("[cyan1]=============================================[/]").Centered());
            AnsiConsole.Write(new Markup("[italic blue] \"Game-Fiesta\" was made by Mihail Petrov[/]").Centered());
        }
    }
}
