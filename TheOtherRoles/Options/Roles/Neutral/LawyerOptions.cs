using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class LawyerOptions : AbstractRoleOptionGroup<LawyerRole>
{
    public override string GroupName => "Lawyer";

    [ModdedNumberOption("Lawyer Vision", 0.25f, 3f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float Vision { get; set; } = 1f;

    [ModdedToggleOption("Lawyer Knows Target Role")]
    public bool KnowsTargetRole { get; set; } = false;

    [ModdedToggleOption("Lawyer Can Call Emergency")]
    public bool CanCallEmergency { get; set; } = true;

    [ModdedToggleOption("Target Can Be Jester")]
    public bool TargetCanBeJester { get; set; } = false;

    [ModdedNumberOption("Blank Cooldown", 5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float BlankCooldown { get; set; } = 30f;

    [ModdedNumberOption("Blanks Number", 1f, 20f, 1f, MiraNumberSuffixes.None)]
    public float BlanksNumber { get; set; } = 5f;
}
