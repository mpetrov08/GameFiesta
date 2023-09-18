using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Managers
{
    public static class Choose
    {
        public static T MakeChoose<T>(List<T> enumarations, List<ConsoleKey> possibleKeys)
        {
            var key = Console.ReadKey();
            if (possibleKeys.Contains(key.Key))
            {
                return enumarations[possibleKeys.IndexOf(key.Key)];
            }
            else
            {
                throw new ArgumentException("Oops. You pressed wrong key.");
            }
        }
    }
}
