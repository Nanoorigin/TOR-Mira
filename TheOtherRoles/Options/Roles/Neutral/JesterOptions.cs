using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class JesterOptions : AbstractRoleOptionGroup<JesterRole>
{
    public override string GroupName => "Jester";

    [ModdedToggleOption("Jester Can Call Emergency")]
    public bool CanCallEmergency { get; set; } = true;

    [ModdedToggleOption("Jester Has Impostor Vision")]
    public bool HasImpostorVision { get; set; } = false;
}
