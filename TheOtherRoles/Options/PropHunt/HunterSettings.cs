using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.PropHunt
{
    internal class HunterSettings : AbstractOptionGroup
    {
        public override string GroupName => "Hunter Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.PropHunt;

        [ModdedNumberOption("Number Of Hunters", 1f, 5f, 1f)]
        public float PropHuntNumberOfHunters { get; set; } = 1f;

        [ModdedNumberOption("Hunter Initial Blackout Duration", 5f, 20f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterInitialBlackoutTime { get; set; } = 10f;

        [ModdedNumberOption("Kill Cooldown After Miss", 2.5f, 60f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterMissCooldown { get; set; } = 10f;

        [ModdedNumberOption("Kill Cooldown After Hit", 2.5f, 60f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterHitCooldown { get; set; } = 10f;

        [ModdedNumberOption("Reveal Prop Cooldown", 10f, 90f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntRevealCooldown { get; set; } = 30f;

        [ModdedNumberOption("Reveal Prop Duration", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntRevealDuration { get; set; } = 5f;

        [ModdedNumberOption("Reveal Time Punish", 0f, 1800f, 5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntRevealPunish { get; set; } = 10f;

        [ModdedNumberOption("Hunter Admin Cooldown", 2.5f, 1800f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntAdminCooldown { get; set; } = 30f;

        [ModdedNumberOption("Find Cooldown", 2.5f, 1800f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntFindCooldown { get; set; } = 60f;

        [ModdedNumberOption("Find Duration", 1f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float PropHuntFindDuration { get; set; } = 5f;
    }
}
