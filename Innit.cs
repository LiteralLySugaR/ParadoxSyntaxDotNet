using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet
{
    public class Innit
    {
        public string Syntax;

        public string Version;

        public string Author;

        public string ModVersion;

        public string ModName;

        public enum SyntaxEnumerator
        {
            HeartsOfIron4
        }

        public Innit(string[] Params)
        {
            Syntax = Params[0];

            Version = Params[1];

            Author = Params[2];

            ModVersion = Params[3];

            ModName = Params[4];

            if (!typeof(SyntaxEnumerator).GetEnumNames().Contains(Syntax)) { Syntax = ((SyntaxEnumerator)0).ToString(); }
        }
    }
}
