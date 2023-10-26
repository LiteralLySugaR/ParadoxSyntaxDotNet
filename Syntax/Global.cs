using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Global
    {
        public object Function;

        public Global(object function)
        {
            Function = function;
        }

        public static string[] CallFunctionParameters()
        {

        }
    }
}
