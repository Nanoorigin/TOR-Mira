using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class TricksterOptions : AbstractRoleOptionGroup<TricksterRole>
{
    public override string GroupName => "Trickster";

    [ModdedNumberOption("Box Cooldown", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float BoxCooldown { get; set; } = 10f;

    [ModdedNumberOption("Lights Out Cooldown", 10f, 60f, 5f, MiraNumberSuffixes.Seconds)]
    public float LightsOutCooldown { get; set; } = 30f;

    [ModdedNumberOption("Lights Out Duration", 5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float LightsOutDuration { get; set; } = 15f;
}
