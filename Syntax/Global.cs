using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Global
    {
        public class MethodComparer
        {
            public static string VarIsGreater { get; } = "<";

            public static string VarIsEquals { get; } = "=";

            public static string VarIsLower { get; } = ">";
        }

        public class DLC
        {
            public static string ArmsAgainstTyranny { get; } = "Arms Against Tyranny";

            public static string ByBloodAlone { get; } = "By Blood Alone";

            public static string NoStepBack { get; } = "No Step Back";

            public static string BattleForTheBosporus { get; } = "Battle for the Bosporus";

            public static string ManTheGuns { get; } = "Man the Guns";

            public static string DeathOrDishonor { get; } = "Death or Dishonor";

            public static string TogetherForVictory { get; } = "Together for Victory";

            public static string LaResistance { get; } = "La Resistance";

            public static string WakingTheTiger { get; } = "Waking the Tiger";
        }

        public class VariableComparer
        {
            public static string VarLessThan { get; } = "less_than";

            public static string VarLessThanOrEquals { get; } = "less_than_or_equals";

            public static string VarEquals { get; } = "equals";

            public static string VarGreaterThanOrEquals { get; } = "greater_than_or_equals";

            public static string VarGreaterThan { get; } = "greater_than";
        }
    }
}
