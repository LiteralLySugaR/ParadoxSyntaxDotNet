using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class Types
    {
        public class GuiTypes
        { public GuiType[] Guis; public readonly string FuncName = "GuiTypes"; }

        public class GuiType
        {
            public string NameDefine;

            public string TextureDefine;

            public int NumberOfFrames;

            public readonly string FuncName = "GuiType";
        }

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

            public FunctionClasses.Decision.Allowed Allowed;

            public FunctionClasses.Decision.Available Available;

            public FunctionClasses.Decision.Visible Visible;

            public DecisionCategory(string name)
            { NameDefine = name; FuncName = NameDefine; }

            public readonly string FuncName;
        }

        public class Decision
        {
            public string NameDefine;

            public int Priority;

            public int DaysRemove;

            public int DaysReEnable;

            public int DaysMissionTimeout;

            public bool SelectableMission;

            public bool IsGood;

            public string IconDefine;

            public int Cost;

            public bool FireOnlyOnce;

            public string WarWithOnRemove;

            public string CustomCostText;

            public bool FixedRandomSeed;

            public bool TargetsDynamic;

            public string TargetArray;

            public FunctionClasses.Decision.TargetRootTrigger TargetRootTrigger;

            public FunctionClasses.Decision.Targets Targets;

            public FunctionClasses.Decision.TargetTrigger TargetTrigger;

            public FunctionClasses.Decision.CustomCostTrigger CustomCostTrigger;

            public FunctionClasses.Decision.Modifier Modifier;

            public FunctionClasses.Decision.Allowed Allowed;

            public FunctionClasses.Decision.Available Available;

            public FunctionClasses.Decision.Visible Visible;

            public FunctionClasses.Decision.TimeoutEffect TimeoutEffect;

            public FunctionClasses.Decision.CompleteEffect CompleteEffect;

            public FunctionClasses.Decision.RemoveEffect RemoveEffect;

            public FunctionClasses.Decision.CancelTrigger CancelTrigger;

            public FunctionClasses.Decision.CancelEffect CancelEffect;

            public Decision(string name)
            { NameDefine = name; FuncName = NameDefine; }

            public readonly string FuncName;
        }
    }
}
