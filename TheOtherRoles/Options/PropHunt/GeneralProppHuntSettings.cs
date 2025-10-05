using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.PropHunt
{
    internal class GeneralProppHuntSettings : AbstractOptionGroup
    {
        public override string GroupName => "General PropHunt Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.PropHunt;

        [ModdedNumberOption("Timer In Min", 1f, 30f, 0.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntTimer { get; set; } = 5f;

        [ModdedNumberOption("Unstuck Cooldown", 2.5f, 60f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntUnstuckCooldown { get; set; } = 30f;


        [ModdedNumberOption("Unstuck Duration", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntUnstuckDuration { get; set; } = 22f;

        [ModdedNumberOption("Hunter Vision", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Multiplier)]
        public float PropHunterVision { get; set; } = 0.5f;

        [ModdedNumberOption("Prop Vision", 0.25f, 5f, 0.25f, MiraAPI.Utilities.MiraNumberSuffixes.Multiplier)]
        public float PropVision { get; set; } = 2f;
    }
}
