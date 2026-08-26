using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class VampireOptions : AbstractRoleOptionGroup<VampireRole>
{
    public override string GroupName => "Vampire";

    [ModdedNumberOption("Vampire Kill Delay", 1f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float KillDelay { get; set; } = 10f;

    [ModdedNumberOption("Vampire Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedToggleOption("Vampire Can Kill Near Garlics")]
    public bool CanKillNearGarlics { get; set; } = true;
}
