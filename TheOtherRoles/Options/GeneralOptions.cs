using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class GeneralOptions : AbstractOptionGroup
{
    public override string GroupName => "General";

    [ModdedNumberOption("Max Meetings", 1f, 20f, 1f, MiraNumberSuffixes.None)]
    public float MaxNumberOfMeetings { get; set; } = 10f;

    [ModdedToggleOption("Block Skipping In Emergency Meetings")]
    public bool BlockSkippingInEmergencyMeetings { get; set; } = false;

    [ModdedToggleOption("No Vote Is Self Vote")]
    public bool NoVoteIsSelfVote { get; set; } = false;

    [ModdedToggleOption("Hide Player Names")]
    public bool HidePlayerNames { get; set; } = false;

    [ModdedToggleOption("Allow Parallel Med Bay Scans")]
    public bool AllowParallelMedBayScans { get; set; } = false;

    [ModdedToggleOption("Shield First Kill")]
    public bool ShieldFirstKill { get; set; } = false;

    [ModdedToggleOption("Ghosts See Roles")]
    public bool GhostsSeeRoles { get; set; } = true;

    [ModdedToggleOption("Ghosts See Modifier")]
    public bool GhostsSeeModifier { get; set; } = true;

    [ModdedToggleOption("Ghosts See Information")]
    public bool GhostsSeeInformation { get; set; } = true;

    [ModdedToggleOption("Ghosts See Votes")]
    public bool GhostsSeeVotes { get; set; } = true;

    [ModdedToggleOption("Show Role Summary")]
    public bool ShowRoleSummary { get; set; } = true;
}
