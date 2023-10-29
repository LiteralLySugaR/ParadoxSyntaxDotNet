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

            public Method(string var, string comparer, string value)
            { FuncName = $"{var.GetType().GetProperty("FuncName").GetValue(var)} {comparer} {value}"; }

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
            {  
                public Always(bool has)
                { FuncName += $" = {ToSyntax(has)}"; }

                public Always(string has)
                { FuncName += $" = {ToSyntax(has)}"; }

                public readonly string FuncName = "always";
            }

            public class HasGlobalFlag
            {
                public object[] Methods;

                public HasGlobalFlag(string flag)
                {
                    Methods = new object[1]
                    {
                        new Method("flag", "=", flag)
                    };
                }

                public HasGlobalFlag(string flag, int days, string daysComparer)
                {
                    Methods = new object[2]
                    {
                        new Method("flag", "=", flag),
                        new Method("days", daysComparer, days.ToString())
                    };
                }

                public HasGlobalFlag(string flag, int days, string daysComparer, string date, string dateComparer)
                {
                    Methods = new object[3]
                    {
                        new Method("flag", "=", flag),
                        new Method("days", daysComparer, days.ToString()),
                        new Method("date", dateComparer, date)
                    };
                }

                public HasGlobalFlag(string flag, int days, string daysComparer, string date, string dateComparer, int value, string valueComparer)
                {
                    Methods = new object[4]
                    {
                        new Method("flag", "=", flag),
                        new Method("days", daysComparer, days.ToString()),
                        new Method("date", dateComparer, date),
                        new Method("value", valueComparer, value.ToString())
                    };
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

            public class HasDLC
            {
                public HasDLC(string dlc)
                { FuncName += $" = {dlc}"; }

                public readonly string FuncName = "has_dlc";
            }

            public class HasStartDate
            {
                public HasStartDate(string targetDate)
                { FuncName += $" = {targetDate}"; }

                public readonly string FuncName = "has_start_date";
            }

            public class Date
            {
                public Date(string targetDate)
                { FuncName += $" = {targetDate}"; }

                public readonly string FuncName = "date";
            }

            public class Difficulty
            {
                public Difficulty(string targetDiff)
                { FuncName += $" = {targetDiff}"; }

                public readonly string FuncName = "difficulty";
            
            }

            public class HasAnyCustomDiffSettings
            { 
                public HasAnyCustomDiffSettings(bool has)
                { FuncName += $" = {ToSyntax(has)}"; }

                public HasAnyCustomDiffSettings(string has)
                { FuncName += $" = {ToSyntax(has)}"; }

                public readonly string FuncName = "has_any_custom_difficulty_settings";
            }

            public class HasCustomDifficultySettings
            {
                public HasCustomDifficultySettings(string targetDiff)
                { FuncName += $" = {targetDiff}"; }

                public readonly string FuncName = "has_custom_difficulty_settings";
            }

            public class GameRulesAllowAchievements
            {
                public GameRulesAllowAchievements(bool allow)
                { FuncName += $" = {ToSyntax(allow)}"; }

                public GameRulesAllowAchievements(string allow)
                { FuncName += $" = {ToSyntax(allow)}"; }

                public readonly string FuncName = "game_rules_allow_achievements";
            }

            public class CountryExists
            {
                public CountryExists(string tag)
                { FuncName += $" = {tag}"; }

                public readonly string FuncName = "country_exists";
            }

            public class IsIronman
            {
                public IsIronman(bool itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public IsIronman(string itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public readonly string FuncName = "is_ironman";
            }

            public class IsHistoricalFocusOn
            {
                public IsHistoricalFocusOn(bool itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public IsHistoricalFocusOn(string itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public readonly string FuncName = "is_historical_focus_on";
            }

            public class IsTutorial
            {
                public IsTutorial(bool itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public IsTutorial(string itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public readonly string FuncName = "is_tutorial";
            }

            public class IsDebug
            {
                public IsDebug(bool itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public IsDebug(string itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public readonly string FuncName = "is_debug";
            }

            public class Threat
            {
                public Threat(string targetThreat)
                { FuncName += $" = {targetThreat}"; }

                public readonly string FuncName = "threat";
            }

            public class HasGameRule
            {
                public object[] Methods;
                public HasGameRule(string gamerule)
                { FuncName += $" = {gamerule}"; }

                public HasGameRule(string gamerule, bool option)
                {
                    Methods = new object[2]
                    {
                        new Method("rule", "=", gamerule),
                        new Method("option", "=", ToSyntax(option))
                    };
                }

                public HasGameRule(string gamerule, string option)
                {
                    Methods = new object[2]
                    {
                        new Method("rule", "=", gamerule),
                        new Method("option", "=", ToSyntax(option))
                    };
                }

                public readonly string FuncName = "has_game_rule";
            }

            public class HasVariable
            {
                public HasVariable(string targetVar)
                { FuncName += $" = {targetVar}"; }

                public readonly string FuncName = "has_variable";
            }

            public class CheckVariable
            {
                public object[] Methods;

                public CheckVariable(string var, string comparer, string value)
                {
                    Methods = new object[3]
                    {
                        new Method("var", "=", var),
                        new Method("value", "=", value),
                        new Method("compare", "=", comparer)
                    };
                }

                public readonly string FuncName = "check_variable";
            }

            public class Log
            {
                public Log(string str)
                { FuncName += $" \"{str}\""; }
                
                public readonly string FuncName = "log";
            }

            public class Exists
            {
                public Exists(bool Do)
                { FuncName += $" = {ToSyntax(Do)}"; }

                public Exists(string Do)
                { FuncName += $" = {ToSyntax(Do)}"; }

                public readonly string FuncName = "exists";
            }

            public class Tag
            {
                public Tag(string tag)
                { FuncName += $" = {tag}"; }

                public readonly string FuncName = "tag";
            }

            public class OriginalTag
            {
                public OriginalTag(string tag)
                { FuncName += $" = {tag}"; }

                public readonly string FuncName = "original_tag";
            }

            public class IsAi
            {
                public IsAi(bool itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public IsAi(string itIs)
                { FuncName += $" = {ToSyntax(itIs)}"; }

                public readonly string FuncName = "is_ai";
            }

            public class HasCollaboration
            {
                public object[] Methods;

                public HasCollaboration(string var, string comparer, string value)
                {
                    Methods = new object[2]
                    {
                        new Method("target", "=", var),
                        new Method("value", comparer, value)
                    };
                }

                public readonly string FuncName = "has_collaboration";
            }
        }

        public class Modifiers
        {

        }

        public class Effects
        {

        }

        public static string ToSyntax(bool var)
        {
            if (var) { return "yes"; }
            else { return "no"; }
        }
        public static string ToSyntax(string var)
        {
            if (var.ToLower().Equals("true") || var.ToLower().Equals("yes")) { return "yes"; }
            else { return "no"; }
        }
        public static bool FromSyntax(string var)
        {
            if (var.Equals("yes")) { return true; }
            else { return false; }
        }
        public static string VarToString(string var)
        {
            return $"[?{var}]";
        }
        public static string MethodToString(string method)
        {
            return $"[{method}]";
        }
    }
}
