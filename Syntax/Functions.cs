using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Functions
    {
        public class Method
        {
            public class Owner
            {
                public string OwnerTag { get; }

                public Owner(string tag)
                { OwnerTag = tag; }

                public readonly string FuncName = "owner";
            }

            public Method(string method, string comparer, string var)
            { FuncName = $"{method.GetType().GetProperty("FuncName").GetValue(method)} {comparer} {var}"; }

            public readonly string FuncName;
        }

        public class Scopes
        {
            public class TAG
            {
                public string Tag { get; }

                public object[] Functions;

                public TAG(string tag)
                { Tag = tag; FuncName = Tag; }

                public readonly string FuncName;
            }

            public class STATE
            {
                public int Id { get; }

                public object[] Functions;

                public STATE(int id)
                { Id = id; FuncName = Id.ToString(); }

                public readonly string FuncName;
            }
        }
        public class Statements
        {
            public class If 
            { public Limit Limit; public object[] Functions; public readonly string FuncName = "if"; }

            public class ElseIf 
            { public Limit Limit; public object[] Functions; public readonly string FuncName = "else_if"; }

            public class Else 
            { public object[] Functions; public readonly string FuncName = "else"; }

            public class Limit 
            { public object[] Triggers; public readonly string FuncName = "limit"; }

            public class OR
            { public object[] Triggers; public readonly string FuncName = "OR"; }

            public class AND
            { public object[] Triggers; public readonly string FuncName = "AND"; }

            public class NOT
            { public object[] Triggers; public readonly string FuncName = "NOT"; }
        }

        public class Triggers
        {

            public class Always
            {  public bool Self; public readonly string FuncName = "always"; }

            public class HasGlobalFlag
            {
                public string Flag { get; }

                public int Days { get; }

                public string Date { get; }

                public int Value { get; }

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

                public readonly string FuncName = "has_global_flag";
            }

            public class TAG
            {
                public string Tag { get; }

                public TAG(string tag)
                { Tag = tag; FuncName = Tag; }

                public readonly string FuncName;
            }

            public class STATE
            {
                public int Id { get; }

                public STATE(int id)
                { Id = id; FuncName = Id.ToString(); }

                public readonly string FuncName;
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
