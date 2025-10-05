using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;

namespace TheOtherRoles.Options.General
{
    internal class NightVisionCams : AbstractOptionGroup
    {
        public override string GroupName => "Night Vision Cams";
        public override Func<bool> GroupVisible => () => TORMapOptions.GameMode == CustomGamemodes.Classic || TORMapOptions.GameMode == CustomGamemodes.Guesser;
        public override uint GroupPriority => 2;

        [ModdedToggleOption("Cams Switch To Night Vision If Lights Are Off")]
        public bool CamsNightVision { get; set; } = false;

        public ModdedToggleOption CamsNoNightVisionIfImpVision { get; } =
            new ModdedToggleOption("Impostor Vision Ignores Night Vision Cams", false)
            {
                Visible = () => OptionGroupSingleton<NightVisionCams>.Instance.CamsNightVision
            };
    }
}
