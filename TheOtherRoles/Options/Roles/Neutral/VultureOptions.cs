using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class VultureOptions : AbstractRoleOptionGroup<VultureRole>
{
    public override string GroupName => "Vulture";

    [ModdedNumberOption("Vulture Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 15f;

    [ModdedNumberOption("Corpses Needed", 1f, 10f, 1f, MiraNumberSuffixes.None)]
    public float CorpsesNeeded { get; set; } = 4f;

    [ModdedToggleOption("Vulture Can Use Vents")]
    public bool CanUseVents { get; set; } = true;

    [ModdedToggleOption("Vulture Show Arrows")]
    public bool ShowArrows { get; set; } = true;
}
