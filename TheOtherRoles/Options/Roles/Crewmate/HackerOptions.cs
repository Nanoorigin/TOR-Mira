using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class HackerOptions : AbstractRoleOptionGroup<HackerRole>
{
    public override string GroupName => "Hacker";

    [ModdedNumberOption("Hacker Cooldown", 5f, 60f, 5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Hacker Duration", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Duration { get; set; } = 10f;

    [ModdedToggleOption("Only Sees Color Type")]
    public bool OnlySeesColorType { get; set; } = false;

    [ModdedNumberOption("Max Charges", 1f, 30f, 1f, MiraNumberSuffixes.None)]
    public float MaxCharges { get; set; } = 5f;

    [ModdedNumberOption("Tasks For Recharge", 1f, 5f, 1f, MiraNumberSuffixes.None)]
    public float TasksForRecharge { get; set; } = 2f;

    [ModdedToggleOption("Hacker Can Move During Duration")]
    public bool CanMoveDuringDuration { get; set; } = true;
}
