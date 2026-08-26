using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class MorphlingOptions : AbstractRoleOptionGroup<MorphlingRole>
{
    public override string GroupName => "Morphling";

    [ModdedNumberOption("Morphling Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Morph Duration", 1f, 20f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float MorphDuration { get; set; } = 10f;
}
