using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class SidekickOptions : AbstractRoleOptionGroup<SidekickRole>
{
    public override string GroupName => "Sidekick";

    [ModdedToggleOption("Promotes To Jackal")]
    public bool PromotesToJackal { get; set; } = true;

    [ModdedToggleOption("Can Kill")]
    public bool CanKill { get; set; } = true;

    [ModdedToggleOption("Can Use Vents")]
    public bool CanUseVents { get; set; } = false;

    [ModdedToggleOption("Can Sabotage Lights")]
    public bool CanSabotageLights { get; set; } = false;
}
