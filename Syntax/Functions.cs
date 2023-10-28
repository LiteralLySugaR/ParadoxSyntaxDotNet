using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Functions
    {
        public class Scopes
        {
            public class TAG
            {
                public readonly string Tag;

                public object[] Functions;

                public TAG(string tag)
                { Tag = tag; }
            }

            public class STATE
            {
                public readonly int Id;

                public object[] Functions;

                public STATE(int id)
                { Id = id; }
            }
        }

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

            public class OR
            { public object[] Triggers; }

            public class AND
            { public object[] Triggers; }

            public class NOT
            { public object[] Triggers; }
        }

        public class Triggers
        {
            public class Always
            {  public bool Self; }

            public class HasGlobalFlag
            {
                public readonly string Flag;

                public readonly int Days;

                public readonly string Date;

                public readonly int Value;

                public string[] Comparer;

                public HasGlobalFlag(string flag)
                { 
                    Flag = flag;
                }

                public HasGlobalFlag(string flag, int days)
                {
                    Flag = flag;
                    Days = days;
                }

                public HasGlobalFlag(string flag, int days, string date)
                {
                    Flag = flag;
                    Days = days;
                    Date = date;
                }

                public HasGlobalFlag(string flag, int days, string date, int value)
                {
                    Flag = flag;
                    Days = days;
                    Date = date;
                    Value = value;
                }
            }

            public class TAG
            {
                public readonly string Tag;

                public TAG(string tag)
                { Tag = tag; }
            }

            public class STATE
            {
                public readonly int Id;

                public STATE(int id)
                { Id = id; }
            }

            public class Owner
            {
                public readonly string OwnerTag;

                public Owner(string tag)
                { OwnerTag = tag; }
            }
        }

        public class Modifiers
        {

        }

        public class Effects
        {

        }
    }
}
