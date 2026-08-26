using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class MafiosoOptions : AbstractRoleOptionGroup<MafiosoRole>
{
    public override string GroupName => "Mafioso";
}
