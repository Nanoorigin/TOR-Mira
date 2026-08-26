using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class MayorOptions : AbstractRoleOptionGroup<MayorRole>
{
    public override string GroupName => "Mayor";

    [ModdedToggleOption("Mayor Can See Vote Colors")]
    public bool CanSeeVoteColors { get; set; } = false;

    [ModdedNumberOption("Tasks Needed To See Vote Colors", 0f, 20f, 1f, MiraNumberSuffixes.None)]
    public float TasksNeededToSeeVoteColors { get; set; } = 5f;

    [ModdedToggleOption("Mobile Emergency Button")]
    public bool MobileEmergencyButton { get; set; } = true;

    [ModdedNumberOption("Number Of Remote Meetings", 1f, 5f, 1f, MiraNumberSuffixes.None)]
    public float NumberOfRemoteMeetings { get; set; } = 1f;
}
