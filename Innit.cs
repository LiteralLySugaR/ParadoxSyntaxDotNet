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

        public string ParadoxSyntaxDotNetVersion;

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

            ParadoxSyntaxDotNetVersion = Params[5];

            if (!typeof(SyntaxEnumerator).GetEnumNames().Contains(Syntax)) { Syntax = ((SyntaxEnumerator)0).ToString(); }
        }

        public void EncodeCall(object EncodingTarget)
        {
            // line 0 - descriptor.mod info
            // line 1 - /common/ info
            // line 2 - /events/ info
            // line 3 - /history/ info
            // line 4 - /localisation/ info
        }
    }
}
