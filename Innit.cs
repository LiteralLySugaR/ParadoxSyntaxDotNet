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

        public string[] ReplacePath;

        public enum SyntaxEnumerator
        {
            HeartsOfIron4
        }

        public Innit(string[] Params, string[] replacePaths)
        {
            Syntax = Params[0];

            Version = Params[1];

            Author = Params[2];

            ModVersion = Params[3];

            ModName = Params[4];

            ReplacePath = replacePaths;

            if (!typeof(SyntaxEnumerator).GetEnumNames().Contains(Syntax)) { Syntax = ((SyntaxEnumerator)0).ToString(); }
        }
    }
}
