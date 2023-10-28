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
            public readonly static string VarIsLower = "<";

            public readonly static string VarIsEquals = "=";

            public readonly static string VarIsGreater = ">";
        }

        public class Field : Global
        { 
            public static object Value = null;

            public static string StrComparer;
        }

        public static Field Year;

        public static Field Date;

        public static Field NumDays;

        public static Field Difficulty;

        public static Field Threat;

        public static Field Id;

        public static Field MaxManpower;

        public static Field MaxManpowerK;

        public static Field CurrentPartyIdeologyGroup;

        public static Field OriginalTag;
    }
}
