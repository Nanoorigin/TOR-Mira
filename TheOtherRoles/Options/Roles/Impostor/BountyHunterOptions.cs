using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class BountyHunterOptions : AbstractRoleOptionGroup<BountyHunterRole>
{
    public override string GroupName => "Bounty Hunter";

    [ModdedNumberOption("Bounty Duration", 10f, 180f, 10f, MiraNumberSuffixes.Seconds)]
    public float BountyDuration { get; set; } = 60f;

    [ModdedNumberOption("Reduced Cooldown", 0f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ReducedCooldown { get; set; } = 2.5f;

    [ModdedNumberOption("Punishment Time", 0f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float PunishmentTime { get; set; } = 20f;

    [ModdedToggleOption("Bounty Hunter Show Arrow")]
    public bool ShowArrow { get; set; } = true;

    [ModdedNumberOption("Arrow Update Interval", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ArrowUpdateInterval { get; set; } = 15f;
}
