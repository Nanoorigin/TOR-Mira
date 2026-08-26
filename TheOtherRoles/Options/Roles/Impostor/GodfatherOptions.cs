using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class GodfatherOptions : AbstractRoleOptionGroup<GodfatherRole>
{
    public override string GroupName => "Godfather";
}
