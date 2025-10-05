using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.GuesserMode
{
    internal class GuesserForceSettings : AbstractOptionGroup
    {
        public override string GroupName => "Force Guessers";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Guesser;

        [ModdedToggleOption("Force Jackal Guesser")]
        public bool GuesserForceJackalGuesser { get; set; } = false;

        [ModdedToggleOption("Sidekick Is Always Guesser")]
        public bool GuesserGamemodeSidekickIsAlwaysGuesser { get; set; } = false;

        [ModdedToggleOption("Force Thief Guesser")]
        public bool GuesserForceThiefGuesser { get; set; } = false;
    }
}