using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class FunctionClasses
    {
        public class Visible : Functions
        {
            public object[] Functions;
        }

        public class Available : Functions
        {
            public object[] Functions;
        }

        public class Allowed : Functions
        {
            public object[] Functions;
        }
    }
}
