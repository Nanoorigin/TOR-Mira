using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class BomberOptions : AbstractRoleOptionGroup<BomberRole>
{
    public override string GroupName => "Bomber";

    [ModdedNumberOption("Destruction Time", 2.5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float DestructionTime { get; set; } = 20f;

    [ModdedNumberOption("Destruction Range", 5f, 150f, 5f, MiraNumberSuffixes.None)]
    public float DestructionRange { get; set; } = 50f;

    [ModdedNumberOption("Hear Range", 5f, 150f, 5f, MiraNumberSuffixes.None)]
    public float HearRange { get; set; } = 60f;

    [ModdedNumberOption("Defuse Duration", 0.5f, 30f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float DefuseDuration { get; set; } = 3f;

    [ModdedNumberOption("Bomber Cooldown", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 15f;

    [ModdedNumberOption("Active After", 0.5f, 15f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float ActiveAfter { get; set; } = 3f;
}
