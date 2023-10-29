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
            public sealed class Activation : Functions.Triggers
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
            public class Effect 
            { public object[] Functions; public readonly string FuncName = "effect"; }

            public class OnStartup
            { public Effect Effect; public readonly string FuncName = "on_startup"; }

            public class OnDaily
            {
                public string Tag { get; }

                public Effect Effect;

                public OnDaily() { }

                public OnDaily(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_daily";
            }

            public class OnWeekly
            {
                public string Tag { get; }

                public Effect Effect;

                public OnWeekly() { }

                public OnWeekly(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_weekly";
            }

            public class OnMonthly
            {
                public string Tag { get; }

                public Effect Effect;

                public OnMonthly() { }

                public OnMonthly(string tag)
                { Tag = tag; FuncName += $"_{Tag}"; }

                public readonly string FuncName = "on_monthly";
            }

            public class OnNukeDrop
            { public Effect Effect; public readonly string FuncName = "on_nuke_drop"; }

            public class OnPrideOfTheFleetSunk
            { public Effect Effect; public readonly string FuncName = "on_pride_of_the_fleet_sunk"; }

            public class OnNavalInvasion
            { public Effect Effect; public readonly string FuncName = "on_naval_invasion"; }

            public class OnParadrop
            { public Effect Effect; public readonly string FuncName = "on_paradrop"; }

            public class OnCoupSucceeded
            { public Effect Effect; public readonly string FuncName = "on_coup_succeeded"; }

            public class OnGovernmentChange
            { public Effect Effect; public readonly string FuncName = "on_government_change"; }

            public class OnRulingPartyChange
            { public Effect Effect; public readonly string FuncName = "on_ruling_party_change"; }

            public class OnNewTermElection
            { public Effect Effect; public readonly string FuncName = "on_new_term_election"; }

            public class OnPeaceconferenceEnded
            { public Effect Effect; public readonly string FuncName = "on_peaceconference_ended"; }

            public class OnPeaceconferenceStarted
            { public Effect Effect; public readonly string FuncName = "on_peaceconference_started"; }

            public class OnSendVolunteers
            { public Effect Effect; public readonly string FuncName = "on_send_volunteers"; }

            public class OnBorderWarLost
            { public Effect Effect; public readonly string FuncName = "on_border_war_lost"; }

            public class OnWarRelationAdded
            { public Effect Effect; public readonly string FuncName = "on_war_relation_added"; }

            public class OnDeclareWar
            { public Effect Effect; public readonly string FuncName = "on_declare_war"; }

            public class OnWar
            { public Effect Effect; public readonly string FuncName = "on_war"; }

            public class OnPeace
            { public Effect Effect; public readonly string FuncName = "on_peace"; }

            public class OnCapitulation
            { public Effect Effect; public readonly string FuncName = "on_capitulation"; }

            public class OnUncapitulation
            { public Effect Effect; public readonly string FuncName = "on_uncapitulation"; }

            public class OnAnnex
            { public Effect Effect; public readonly string FuncName = "on_annex"; }

            public class OnCivilWarEndBeforeAnnexation
            { public Effect Effect; public readonly string FuncName = "on_civil_war_end_before_annexation"; }

            public class OnCivilWarEnd
            { public Effect Effect; public readonly string FuncName = "on_civil_war_end"; }

            public class OnPuppet
            { public Effect Effect; public readonly string FuncName = "on_puppet"; }

            public class OnLiberate
            { public Effect Effect; public readonly string FuncName = "on_liberate"; }

            public class OnReleaseAsFree
            { public Effect Effect; public readonly string FuncName = "on_release_as_free"; }

            public class OnReleaseAsPuppet
            { public Effect Effect; public readonly string FuncName = "on_release_as_puppet"; }

            public object[] SelfFunctions;
        }
    }
}
