using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class PursuerOptions : AbstractRoleOptionGroup<PursuerRole>
{
    public override string GroupName => "Pursuer";

    [ModdedNumberOption("Cooldown", 5f, 120f, 2.5f)]
    public float Cooldown { get; set; } = 30f;
}
