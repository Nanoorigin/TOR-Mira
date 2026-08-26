using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class HideNSeekOptions : AbstractOptionGroup
{
    public override string GroupName => "Hide & Seek";

    [ModdedNumberOption("Hunter Count", 1f, 5f, 1f, MiraNumberSuffixes.None)]
    public float HideNSeekHunterCount { get; set; } = 1f;

    [ModdedNumberOption("Kill Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HideNSeekKillCooldown { get; set; } = 10f;

    [ModdedNumberOption("Hunter Vision", 0.25f, 3f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float HideNSeekHunterVision { get; set; } = 1f;

    [ModdedNumberOption("Hunted Vision", 0.25f, 3f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float HideNSeekHuntedVision { get; set; } = 0.25f;

    [ModdedNumberOption("Timer", 30f, 600f, 10f, MiraNumberSuffixes.Seconds)]
    public float HideNSeekTimer { get; set; } = 300f;

    [ModdedToggleOption("Task Win")]
    public bool HideNSeekTaskWin { get; set; } = true;

    [ModdedToggleOption("Can Sabotage")]
    public bool HideNSeekCanSabotage { get; set; } = false;

    [ModdedNumberOption("Hunter Light Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HunterLightCooldown { get; set; } = 30f;

    [ModdedNumberOption("Hunter Light Duration", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HunterLightDuration { get; set; } = 5f;
}
