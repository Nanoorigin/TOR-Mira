using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class WarlockOptions : AbstractRoleOptionGroup<WarlockRole>
{
    public override string GroupName => "Warlock";

    [ModdedNumberOption("Warlock Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Warlock Root Time", 0f, 15f, 1f, MiraNumberSuffixes.Seconds)]
    public float RootTime { get; set; } = 5f;
}
