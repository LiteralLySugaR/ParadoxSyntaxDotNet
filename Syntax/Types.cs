using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Types
    {
        public class DecisionCategory
        {
            public enum VisiblityTypes
            {
                map_and_decision_view
            }

            public Decision[] Decisions;

            public string NameDefine;

            public string IconDefine;

            public string PictureDefine;

            public int Priority;

            public bool VisibleWhenEmpty;

            public VisiblityTypes VisiblityType;

            public FunctionClasses.Visible Visible;

            public FunctionClasses.Allowed Allowed;
        }

        public class Decision
        {
            public int Priority;

            public string IconDefine;

            public int Cost;

            public FunctionClasses.Available Available;

            public FunctionClasses.Allowed Allowed;

            public FunctionClasses.Visible Visible;
        }
    }
}
