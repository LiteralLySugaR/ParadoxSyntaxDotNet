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
        { public GuiType[] Guis; }

        public class GuiType
        {
            public string NameDefine;

            public string TextureDefine;

            public int NumberOfFrames;
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

            public FunctionClasses.Allowed Allowed;

            public FunctionClasses.Available Available;

            public FunctionClasses.Visible Visible;
        }

        public class Decision
        {
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

            public FunctionClasses.TargetRootTrigger TargetRootTrigger;

            public FunctionClasses.Targets Targets;

            public FunctionClasses.TargetTrigger TargetTrigger;

            public FunctionClasses.CustomCostTrigger CustomCostTrigger;

            public FunctionClasses.Modifier Modifier;

            public FunctionClasses.Allowed Allowed;

            public FunctionClasses.Available Available;

            public FunctionClasses.Visible Visible;

            public FunctionClasses.TimeoutEffect TimeoutEffect;

            public FunctionClasses.CompleteEffect CompleteEffect;

            public FunctionClasses.RemoveEffect RemoveEffect;

            public FunctionClasses.CancelTrigger CancelTrigger;

            public FunctionClasses.CancelEffect CancelEffect;
        }
    }
}
