using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options.HideNSeek
{
    internal class GeneralHideNSeekSettings : AbstractOptionGroup
    {
        public override string GroupName => "General Hide N Seek Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.HideNSeek;

        [ModdedNumberOption("Number Of Hunters", 1f, 3f, 1f, MiraNumberSuffixes.None)]
        public float HideNSeekHunterCount { get; set; } = 1f;

        [ModdedNumberOption("Kill Cooldown", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
        public float HideNSeekKillCooldown { get; set; } = 10f;

        [ModdedNumberOption("Hunter Vision", 0.25f, 2f, 0.25f, MiraNumberSuffixes.None)]
        public float HideNSeekHunterVision { get; set; } = 0.5f;

        [ModdedNumberOption("Hunted Vision", 0.25f, 5f, 0.25f, MiraNumberSuffixes.None)]
        public float HideNSeekHuntedVision { get; set; } = 2f;

        [ModdedNumberOption("Common Tasks", 0f, 4f, 1f, MiraNumberSuffixes.None)]
        public float HideNSeekCommonTasks { get; set; } = 1f;

        [ModdedNumberOption("Short Tasks", 1f, 23f, 1f, MiraNumberSuffixes.None)]
        public float HideNSeekShortTasks { get; set; } = 3f;

        [ModdedNumberOption("Long Tasks", 0f, 15f, 1f, MiraNumberSuffixes.None)]
        public float HideNSeekLongTasks { get; set; } = 3f;

        [ModdedNumberOption("Timer In Min", 1f, 30f, 0.5f, MiraNumberSuffixes.None, "0.0Min")]
        public float HideNSeekTimer { get; set; } = 5f;

        [ModdedToggleOption("Task Win Is Possible")]
        public bool HideNSeekTaskWin { get; set; } = false;

        [ModdedNumberOption("Finish Tasks Punish In Sec", 0f, 30f, 1f, MiraNumberSuffixes.Seconds)]
        public float HideNSeekTaskPunish { get; set; } = 10f;

        [ModdedToggleOption("Enable Sabotages")]
        public bool HideNSeekCanSabotage { get; set; } = false;

        [ModdedNumberOption("Time The Hunter Needs To Wait", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
        public float HideNSeekHunterWaiting { get; set; } = 15f;
    }
}
