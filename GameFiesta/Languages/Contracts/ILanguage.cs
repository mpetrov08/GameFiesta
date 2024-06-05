using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Languages.Contracts
{
    public interface ILanguage
    {
        List<string> HangmanWords { get; }

        void PrintSetUpMessage();

        void PrintLanguageChooseMessage();

        void PrintBackMessage();

        void PrintContinueMessage();

        void PrintGameMenu();

        void PrintErrorMessage();

        void PrintCowsAndBullsHeader();

        void PrintCowsAndBullsInputMessage();

        void PrintCowsAndBullsOutputMessage(int bulls, int cows);

        void PrintCowsAndBullsWinningMessage(int tryes, string correctCombination);

        void PrintHangmanHeader();

        void PrintHangmanDiscoveredMessage();

        void PrintHangmanWrongLettersMessage(List<char> alreadyUsedLetters);

        void PrintHangmanInputMessage();

        void PrintHangmanWinningMessage(string word);

        void PrintHangmanLoseMessage(string hangman, string word);

        void PrintHangmanMisstakesMessage(int misstakes);

        void PrintTikTakToeHeader();

        void PrintTikTakToePlayer1Message();

        void PrintTikTakToePlayer2Message();

        void PrintTikTakToeInputMessage(string playerName);

        void PrintTikTakToeWrongCoordinatesMessage();

        void PrintTikTakToeDrawMessage();

        void PrintTikTakToeWinningMessage(string winner);

        void PrintRules();
    }
}
