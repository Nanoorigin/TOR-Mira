using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class MediumOptions : AbstractRoleOptionGroup<MediumRole>
{
    public override string GroupName => "Medium";

    [ModdedNumberOption("Questioning Cooldown", 5f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float QuestioningCooldown { get; set; } = 30f;

    [ModdedNumberOption("Questioning Duration", 0f, 15f, 1f, MiraNumberSuffixes.Seconds)]
    public float QuestioningDuration { get; set; } = 3f;

    [ModdedToggleOption("Each Soul One Time Use")]
    public bool EachSoulOneTimeUse { get; set; } = false;

    [ModdedNumberOption("Chance Additional Info", 0f, 100f, 10f, MiraNumberSuffixes.None)]
    public float ChanceAdditionalInfo { get; set; } = 0f;
}
