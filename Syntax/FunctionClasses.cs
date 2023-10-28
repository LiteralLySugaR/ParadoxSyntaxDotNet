using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class FunctionClasses
    {
        public class Activation : Functions
        { public object[] Functions; }

        public class TargetRootTrigger : Functions
        { public object[] Functions; }

        public class Targets : Functions
        { public object[] Functions; }

        public class TargetTrigger : Functions
        { public object[] Functions; }

        public class Visible : Functions
        { public object[] Functions; }

        public class Available : Functions
        { public object[] Functions; }

        public class Allowed : Functions
        {  public object[] Functions; }

        public class Modifier : Functions
        { public object[] Functions; }

        public class TimeoutEffect : Functions
        { public object[] Functions; }

        public class CompleteEffect : Functions
        { public object[] Functions; }

        public class RemoveEffect : Functions
        { public object[] Functions; }

        public class CancelTrigger : Functions
        { public object[] Functions; }

        public class CancelEffect : Functions
        { public object[] Functions; }

        public class CustomCostTrigger : Functions
        { public object[] Functions; }
    }
}
