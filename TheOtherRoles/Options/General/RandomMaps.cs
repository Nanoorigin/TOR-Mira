using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;

namespace TheOtherRoles.Options.General
{
    internal class RandomMaps : AbstractOptionGroup
    {
        public override string GroupName => "Random Maps";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Classic || TORMapOptions.GameMode == CustomGamemodes.Guesser;
        public override uint GroupPriority => 3;

        [ModdedToggleOption("Play On A Random Map")]
        public bool DynamicMap { get; set; } = false;

        public ModdedNumberOption DynamicMapEnableSkeld { get; } =
            new ModdedNumberOption("Skeld", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedNumberOption DynamicMapEnableMira { get; } =
            new ModdedNumberOption("Mira", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedNumberOption DynamicMapEnablePolus { get; } =
            new ModdedNumberOption("Polus", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedNumberOption DynamicMapEnableAirship { get; } =
            new ModdedNumberOption("Airship", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedNumberOption DynamicMapEnableFungle { get; } =
            new ModdedNumberOption("Fungle", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedNumberOption DynamicMapEnableSubmerged { get; } =
            new ModdedNumberOption("Submerged", 0f, 0f, 100f, 10f, MiraAPI.Utilities.MiraNumberSuffixes.Percent)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };

        public ModdedToggleOption DynamicMapSeparateSettings { get; } =
            new ModdedToggleOption("Use Random Map Setting Presets", false)
            {
                Visible = () => OptionGroupSingleton<RandomMaps>.Instance.DynamicMap
            };
    }
}
