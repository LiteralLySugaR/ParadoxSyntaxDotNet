using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParadoxSyntaxDotNet.Syntax.Triggers;

namespace ParadoxSyntaxDotNet.Syntax.Functions
{
    public class Core
    {
        public Dictionary<string, object> Functions = new Dictionary<string, object>
        {
            { "Always", new Always() },
            { "Available", new Available() }
        };
    }
}
