using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Functions
    {
        public class Statements
        {
            public class If 
            { public Limit Limit; public object[] Functions; }

            public class ElseIf 
            { public Limit Limit; public object[] Functions; }

            public class Else 
            { public object[] Functions; }

            public class Limit 
            { public object[] Triggers; }
        }

        public class Triggers
        {
            public class Always
            {  public bool Self; }

            public class AllCountries
            { public object[] Triggers; }
        }

        public class Modifiers
        {

        }

        public class Effects
        {

        }
    }
}
