using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
namespace TheOtherRoles.Options.GuesserMode
{
    internal class GuesserGeneralSettings : AbstractOptionGroup
    {
        public override string GroupName => "General Guesser Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Guesser;

        [ModdedToggleOption("Guessers Can Have A Modifier")] 
        public bool GuesserGamemodeHaveModifier { get; set; } = true;

        [ModdedNumberOption("Guesser Number Of Shots", 1f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)] 
        public float GuesserGamemodeNumberOfShots { get; set; } = 3f;

        [ModdedToggleOption("Guesser Can Shoot Multiple Times Per Meeting")] 
        public bool GuesserGamemodeHasMultipleShotsPerMeeting { get; set; } = false;

        [ModdedNumberOption("Number Of Tasks Needed To Unlock Shooting\nFor Crew Guesser", 0f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float GuesserGamemodeCrewGuesserNumberOfTasks { get; set; } = 0f;

        [ModdedToggleOption("Guesses Ignore The Medic Shield")] 
        public bool GuesserGamemodeKillsThroughShield { get; set; } = true;

        [ModdedToggleOption("Evil Guesser Can Guess The Spy")] 
        public bool GuesserGamemodeEvilCanKillSpy { get; set; } = true;

        [ModdedToggleOption("Guesser Can't Guess Snitch When Tasks Completed")]
        public bool GuesserGamemodeCantGuessSnitchIfTaksDone { get; set; } = true;
    }
}