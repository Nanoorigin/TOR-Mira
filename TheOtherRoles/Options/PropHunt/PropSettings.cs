using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;

namespace TheOtherRoles.Options.PropHunt
{
    internal class PropSettings : AbstractOptionGroup
    {
        public override string GroupName => "Prop Settings";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.PropHunt;

        public static string propBecomesHunterWhenFoundText = TORHelpers.cs(Palette.CrewmateBlue, "");
        [ModdedToggleOption("Props Become Hunters When Found")]
        public bool PropBecomesHunterWhenFound { get; set; } = false;

        [ModdedToggleOption("Invisibility Enabled")]
        public bool PropHuntInvisEnabled { get; set; } = true;

        public ModdedNumberOption PropHuntInvisCooldown { get; } =
            new ModdedNumberOption("Invisibility Cooldown", 120f, 10f, 1800f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)
            {
                Visible = () => OptionGroupSingleton<PropSettings>.Instance.PropHuntInvisEnabled
            };

        public ModdedNumberOption PropHuntInvisDuration { get; } =
            new ModdedNumberOption("Invisibility Duration", 5f, 1f, 30f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)
            {
                Visible = () => OptionGroupSingleton<PropSettings>.Instance.PropHuntInvisEnabled
            };

        [ModdedToggleOption("Speedboost Enabled")]
        public bool PropHuntSpeedboostEnabled { get; set; } = true;

        public ModdedNumberOption PropHuntSpeedboostCooldown { get; } =
            new ModdedNumberOption("Speedboost Cooldown", 60f, 2.5f, 1800f, 2.5f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)
            {
                Visible = () => OptionGroupSingleton<PropSettings>.Instance.PropHuntSpeedboostEnabled
            };

        public ModdedNumberOption PropHuntSpeedboostDuration { get; } =
            new ModdedNumberOption("Speedboost Duration", 5f, 1f, 15f, 1f, MiraAPI.Utilities.MiraNumberSuffixes.Seconds)
            {
                Visible = () => OptionGroupSingleton<PropSettings>.Instance.PropHuntSpeedboostEnabled
            };

        public ModdedNumberOption PropHuntSpeedboostSpeed { get; } =
            new ModdedNumberOption("Speedboost Ratio", 2f, 1.25f, 5f, 0.25f, MiraAPI.Utilities.MiraNumberSuffixes.Multiplier)
            {
                Visible = () => OptionGroupSingleton<PropSettings>.Instance.PropHuntSpeedboostEnabled
            };
    }
}
