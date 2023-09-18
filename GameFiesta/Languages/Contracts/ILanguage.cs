using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Languages.Contracts
{
    public interface ILanguage
    {
        void PrintSetUpMessage();

        void PrintLanguageChooseMessage();

        void PrintBackMessage();

        void PrintGameMenu();
    }
}
