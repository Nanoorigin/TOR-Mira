using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SpyOptions : AbstractRoleOptionGroup<SpyRole>
{
    public override string GroupName => "Spy";

    [ModdedToggleOption("Spy Can Die To Sheriff")]
    public bool CanDieToSheriff { get; set; } = false;

    [ModdedToggleOption("Impostors Can Kill Anyone")]
    public bool ImpostorsCanKillAnyone { get; set; } = true;

    [ModdedToggleOption("Spy Can Enter Vents")]
    public bool CanEnterVents { get; set; } = false;

    [ModdedToggleOption("Spy Has Impostor Vision")]
    public bool HasImpostorVision { get; set; } = false;
}
