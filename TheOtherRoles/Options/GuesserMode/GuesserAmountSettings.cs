using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.GuesserMode
{
    internal class GuesserAmountSettings : AbstractOptionGroup
    {
        public override string GroupName => "Amount of Guessers";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Guesser;

        [ModdedNumberOption("Number of Crew Guessers", 0f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float GuesserGamemodeCrewNumber { get; set; } = 15f;

        [ModdedNumberOption("Number of Neutral Guessers", 0f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float GuesserGamemodeNeutralNumber { get; set; } = 15f;

        [ModdedNumberOption("Number of Impostor Guessers", 0f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float GuesserGamemodeImpNumber { get; set; } = 15f;
    }
}