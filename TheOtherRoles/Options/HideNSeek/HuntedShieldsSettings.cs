using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.HideNSeek
{
    internal class HuntedShieldSettings : AbstractOptionGroup
    {
        public override string GroupName => "Hunted Shields Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.HideNSeek;

        [ModdedNumberOption("Hunted Shield Cooldown", 5f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HuntedShieldCooldown { get; set; } = 30f;

        [ModdedNumberOption("Hunted Shield Duration", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HuntedShieldDuration { get; set; } = 5f;

        [ModdedNumberOption("Hunted Rewind Time", 1f, 10f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HuntedShieldRewindTime { get; set; } = 3f;

        [ModdedNumberOption("Hunted Shield Number", 1f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float HuntedShieldNumber { get; set; } = 3f;
    }
}
