using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TheOtherRoles.Options.HideNSeek
{
    internal class HunterRolesSettings : AbstractOptionGroup
    {
        public override string GroupName => "Hunter Role Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.HideNSeek;

        [ModdedNumberOption("Hunter Light Cooldown", 5f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterLightCooldown { get; set; } = 30f;

        [ModdedNumberOption("Hunter Light Duration", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterLightDuration { get; set; } = 5f;

        [ModdedNumberOption("Hunter Light Vision", 1f, 5f, 0.25f, MiraAPI.Utilities.MiraNumberSuffixes.None)]
        public float HunterLightVision { get; set; } = 3f;

        [ModdedNumberOption("Hunter Light Punish In Sec", 0f, 30f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterLightPunish { get; set; } = 5f;

        [ModdedNumberOption("Hunter Admin Cooldown", 5f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterAdminCooldown { get; set; } = 30f;

        [ModdedNumberOption("Hunter Admin Duration", 1f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterAdminDuration { get; set; } = 5f;

        [ModdedNumberOption("Hunter Admin Punish In Sec", 0f, 30f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterAdminPunish { get; set; } = 5f;

        [ModdedNumberOption("Hunter Arrow Cooldown", 5f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterArrowCooldown { get; set; } = 30f;

        [ModdedNumberOption("Hunter Arrow Duration", 0f, 60f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterArrowDuration { get; set; } = 5f;

        [ModdedNumberOption("Hunter Arrow Punish In Sec", 0f, 30f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)]
        public float HunterArrowPunish { get; set; } = 5f;
    }
}
