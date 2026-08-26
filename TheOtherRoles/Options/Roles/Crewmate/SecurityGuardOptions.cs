using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SecurityGuardOptions : AbstractRoleOptionGroup<SecurityGuardRole>
{
    public override string GroupName => "Security Guard";

    [ModdedNumberOption("Security Guard Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Total Screws", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float TotalScrews { get; set; } = 7f;

    [ModdedNumberOption("Screws Per Cam", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float ScrewsPerCam { get; set; } = 2f;

    [ModdedNumberOption("Screws Per Vent", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float ScrewsPerVent { get; set; } = 1f;

    [ModdedNumberOption("Cam Duration", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float CamDuration { get; set; } = 10f;

    [ModdedNumberOption("Max Charges", 1f, 30f, 1f, MiraNumberSuffixes.None)]
    public float MaxCharges { get; set; } = 5f;

    [ModdedNumberOption("Tasks For Recharge", 1f, 10f, 1f, MiraNumberSuffixes.None)]
    public float TasksForRecharge { get; set; } = 3f;

    [ModdedToggleOption("Security Guard Can Move During Duration")]
    public bool CanMoveDuringDuration { get; set; } = true;
}
