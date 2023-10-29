using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Global
    {
        public class Comparer
        {
            public static string VarIsGreater { get; } = "<";

            public static string VarIsEquals { get; } = "=";

            public static string VarIsLower { get; } = ">";
        }

        public class Field : Global
        { 
            public static object Value = null;

            public static string StrComparer;
        }

        public static Field Year { get; }

        public static Field Date { get; }

        public static Field NumDays { get; }

        public static Field Difficulty { get; }

        public static Field Threat { get; }

        public static Field Id { get; }

        public static Field MaxManpower { get; }

        public static Field MaxManpowerK { get; }

        public static Field CurrentPartyIdeologyGroup { get; }

        public static Field OriginalTag { get; }
    }
}
