using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class NinjaOptions : AbstractRoleOptionGroup<NinjaRole>
{
    public override string GroupName => "Ninja";

    [ModdedNumberOption("Mark Cooldown", 10f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float MarkCooldown { get; set; } = 30f;

    [ModdedToggleOption("Ninja Knows Target Location")]
    public bool KnowsTargetLocation { get; set; } = true;

    [ModdedNumberOption("Trace Duration", 1f, 20f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float TraceDuration { get; set; } = 5f;

    [ModdedNumberOption("Trace Color Fade Time", 0f, 20f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float TraceColorFadeTime { get; set; } = 2f;

    [ModdedNumberOption("Invisible Duration", 0f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float InvisibleDuration { get; set; } = 3f;
}
