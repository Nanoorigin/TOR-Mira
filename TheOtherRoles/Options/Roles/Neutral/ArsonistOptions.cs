using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class ArsonistOptions : AbstractRoleOptionGroup<ArsonistRole>
{
    public override string GroupName => "Arsonist";

    [ModdedNumberOption("Arsonist Cooldown", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 12.5f;

    [ModdedNumberOption("Douse Duration", 1f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float DouseDuration { get; set; } = 3f;
}
