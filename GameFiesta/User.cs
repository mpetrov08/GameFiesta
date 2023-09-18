using GameFiesta.Languages;
using GameFiesta.Languages.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta
{
    public class User
    {
        public User()
        {
            Language = new English();
        }

        public string Name { get; set; }

        public ILanguage Language { get; set; }

        public BigInteger Points { get; set; }
    }
}
