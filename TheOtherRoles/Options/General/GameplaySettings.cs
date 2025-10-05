using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.General
{
    internal class GameplaySettings : AbstractOptionGroup
    {
        public override string GroupName => "Gameplay Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Classic || TORMapOptions.GameMode == CustomGamemodes.Guesser;
        public override uint GroupPriority => 1;

        [ModdedNumberOption("Number Of Meetings (excluding Mayor meeting)", min: 0, max: 15, increment: 1f)]
        public float MaxNumberOfMeetings { get; set; } = 10f;

        [ModdedToggleOption("Any Player Can Stop The Start")]
        public bool AnyPlayerCanStopStart { get; set; } = false;

        [ModdedToggleOption("Block Skipping In Emergency Meetings")]
        public bool BlockSkippingInEmergencyMeetings { get; set; } = false;

        [ModdedToggleOption("No Vote Is Self Vote")]
        public bool NoVoteIsSelfVote { get; set; } = false;

        [ModdedToggleOption("Hide Player Names")]
        public bool HidePlayerNames { get; set; } = false;

        [ModdedToggleOption("Allow Parallel MedBay Scans")]
        public bool AllowParallelMedBayScans { get; set; } = false;

        [ModdedToggleOption("Shield Last Game First Kill")]
        public bool ShieldFirstKill { get; set; } = false;

        [ModdedToggleOption("Finish Tasks Before Haunting Or Zooming Out")]
        public bool FinishTasksBeforeHauntingOrZoomingOut { get; set; } = true;

        [ModdedToggleOption("Block Dead Impostor From Sabotaging")]
        public bool DeadImpsBlockSabotage { get; set; } = false;
    }
}
