using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class RoleCountOptions : AbstractOptionGroup
{
    public override string GroupName => "Role Counts";

    [ModdedNumberOption("Minimum Crewmate Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float CrewmateRolesCountMin { get; set; } = 15f;

    [ModdedNumberOption("Maximum Crewmate Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float CrewmateRolesCountMax { get; set; } = 15f;

    [ModdedNumberOption("Minimum Neutral Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float NeutralRolesCountMin { get; set; } = 15f;

    [ModdedNumberOption("Maximum Neutral Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float NeutralRolesCountMax { get; set; } = 15f;

    [ModdedNumberOption("Minimum Impostor Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float ImpostorRolesCountMin { get; set; } = 15f;

    [ModdedNumberOption("Maximum Impostor Roles", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float ImpostorRolesCountMax { get; set; } = 15f;

    [ModdedToggleOption("Fill Crewmate Roles")]
    public bool CrewmateRolesFill { get; set; } = false;
}
