using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class FunctionClasses
    {
        public class Decision
        {
            public class Activation : Functions
            { public object[] Functions; public readonly string FuncName = "activation"; }

            public class TargetRootTrigger : Functions
            { public object[] Functions; public readonly string FuncName = "target_root_trigger"; }

            public class Targets : Functions
            { public object[] Functions; public readonly string FuncName = "targets"; }

            public class TargetTrigger : Functions
            { public object[] Functions; public readonly string FuncName = "target_trigger"; }

            public class Visible : Functions
            { public object[] Functions; public readonly string FuncName = "visible"; }

            public class Available : Functions
            { public object[] Functions; public readonly string FuncName = "available"; }

            public class Allowed : Functions
            { public object[] Functions; public readonly string FuncName = "allowed"; }

            public class Modifier : Functions
            { public object[] Functions; public readonly string FuncName = "modifier"; }

            public class TimeoutEffect : Functions
            { public object[] Functions; public readonly string FuncName = "timeout_effect"; }

            public class CompleteEffect : Functions
            { public object[] Functions; public readonly string FuncName = "complete_effect"; }

            public class RemoveEffect : Functions
            { public object[] Functions; public readonly string FuncName = "remove_effect"; }

            public class CancelTrigger : Functions
            { public object[] Functions; public readonly string FuncName = "cancel_trigger"; }

            public class CancelEffect : Functions
            { public object[] Functions; public readonly string FuncName = "cancel_effect"; }

            public class CustomCostTrigger : Functions
            { public object[] Functions; public readonly string FuncName = "custom_cost_trigger"; }
        }

        public class OnActions
        {
            public class Effect : Functions
            { public object[] Functions; public readonly string FuncName = "effect"; }

            public class OnStartup
            { public Effect Effect; public readonly string FuncName = "on_startup"; }

            public class OnDaily : Functions
            {
                public string Tag { get; }

                public Effect Effect;

                public OnDaily() { }

                public OnDaily(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_daily";
            }

            public class OnWeekly : Functions
            {
                public string Tag { get; }

                public Effect Effect;

                public OnWeekly() { }

                public OnWeekly(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_weekly";
            }

            public class OnMonthly : Functions
            {
                public string Tag { get; }

                public Effect Effect;

                public OnMonthly() { }

                public OnMonthly(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_monthly";
            }

            public class OnNukeDrop : Functions
            { public Effect Effect; public readonly string FuncName = "on_nuke_drop"; }

            public class OnPrideOfTheFleetSunk : Functions
            { public Effect Effect; public readonly string FuncName = "on_pride_of_the_fleet_sunk"; }

            public class OnNavalInvasion : Functions
            { public Effect Effect; public readonly string FuncName = "on_naval_invasion"; }

            public class OnParadrop : Functions
            { public Effect Effect; public readonly string FuncName = "on_paradrop"; }

            public class OnCoupSucceeded : Functions
            { public Effect Effect; public readonly string FuncName = "on_coup_succeeded"; }

            public class OnGovernmentChange : Functions
            { public Effect Effect; public readonly string FuncName = "on_government_change"; }

            public class OnRulingPartyChange : Functions
            { public Effect Effect; public readonly string FuncName = "on_ruling_party_change"; }

            public class OnNewTermElection : Functions
            { public Effect Effect; public readonly string FuncName = "on_new_term_election"; }

            public class OnPeaceconferenceEnded : Functions
            { public Effect Effect; public readonly string FuncName = "on_peaceconference_ended"; }

            public class OnPeaceconferenceStarted : Functions
            { public Effect Effect; public readonly string FuncName = "on_peaceconference_started"; }

            public class OnSendVolunteers : Functions
            { public Effect Effect; public readonly string FuncName = "on_send_volunteers"; }

            public class OnBorderWarLost : Functions
            { public Effect Effect; public readonly string FuncName = "on_border_war_lost"; }

            public class OnWarRelationAdded : Functions
            { public Effect Effect; public readonly string FuncName = "on_war_relation_added"; }

            public class OnDeclareWar : Functions
            { public Effect Effect; public readonly string FuncName = "on_declare_war"; }

            public class OnWar : Functions
            { public Effect Effect; public readonly string FuncName = "on_war"; }

            public class OnPeace : Functions
            { public Effect Effect; public readonly string FuncName = "on_peace"; }

            public class OnCapitulation : Functions
            { public Effect Effect; public readonly string FuncName = "on_capitulation"; }

            public class OnUncapitulation : Functions
            { public Effect Effect; public readonly string FuncName = "on_uncapitulation"; }

            public class OnAnnex : Functions
            { public Effect Effect; public readonly string FuncName = "on_annex"; }

            public class OnCivilWarEndBeforeAnnexation : Functions
            { public Effect Effect; public readonly string FuncName = "on_civil_war_end_before_annexation"; }

            public class OnCivilWarEnd : Functions
            { public Effect Effect; public readonly string FuncName = "on_civil_war_end"; }

            public class OnPuppet : Functions
            { public Effect Effect; public readonly string FuncName = "on_puppet"; }

            public class OnLiberate : Functions
            { public Effect Effect; public readonly string FuncName = "on_liberate"; }

            public class OnReleaseAsFree : Functions
            { public Effect Effect; public readonly string FuncName = "on_release_as_free"; }

            public class OnReleaseAsPuppet : Functions
            { public Effect Effect; public readonly string FuncName = "on_release_as_puppet"; }

            public object[] SelfFunctions;

            public readonly string FuncName = "on_actions";
        }
    }
}
