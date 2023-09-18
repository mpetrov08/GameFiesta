using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Managers
{
    public static class Logo
    {
        public static void PrintLogo()
        {
            AnsiConsole.Write(new FigletText("Game-Fiesta").Centered().Color(Color.Cyan1));
        }
    }
}
