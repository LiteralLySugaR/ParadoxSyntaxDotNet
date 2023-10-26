using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allowed = ParadoxSyntaxDotNet.Syntax.Functions.Allowed;
using Available = ParadoxSyntaxDotNet.Syntax.Functions.Available;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Types
    {
        public class Decision
        {
            public int Priority;

            public string IconDefine;

            public int Cost;

            public bool DoReadAvailable;
            public Available Available;

            public bool DoReadAllowed;
            public Allowed Allowed;
        }
    }
}
