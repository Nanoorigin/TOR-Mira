using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class LighterOptions : AbstractRoleOptionGroup<LighterRole>
{
    public override string GroupName => "Lighter";

    [ModdedNumberOption("Vision On Lights On", 0.25f, 5f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float VisionOnLightsOn { get; set; } = 1.5f;

    [ModdedNumberOption("Vision On Lights Off", 0.25f, 5f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float VisionOnLightsOff { get; set; } = 0.5f;

    [ModdedNumberOption("Flashlight Width", 0.1f, 1f, 0.1f, MiraNumberSuffixes.Multiplier)]
    public float FlashlightWidth { get; set; } = 0.3f;
}
