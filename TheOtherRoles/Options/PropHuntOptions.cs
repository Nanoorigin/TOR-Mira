using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class PropHuntOptions : AbstractOptionGroup
{
    public override string GroupName => "Prop Hunt";

    [ModdedNumberOption("Timer", 30f, 600f, 10f, MiraNumberSuffixes.Seconds)]
    public float PropHuntTimer { get; set; } = 300f;

    [ModdedNumberOption("Number Of Hunters", 1f, 5f, 1f, MiraNumberSuffixes.None)]
    public float PropHuntNumberOfHunters { get; set; } = 1f;

    [ModdedNumberOption("Initial Blackout Time", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HunterInitialBlackoutTime { get; set; } = 5f;

    [ModdedNumberOption("Miss Cooldown", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HunterMissCooldown { get; set; } = 5f;

    [ModdedNumberOption("Hit Cooldown", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HunterHitCooldown { get; set; } = 10f;

    [ModdedNumberOption("Hunter Vision", 0.25f, 3f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float PropHunterVision { get; set; } = 1f;

    [ModdedNumberOption("Prop Vision", 0.25f, 3f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float PropVision { get; set; } = 0.25f;

    [ModdedToggleOption("Enable Invisibility")]
    public bool PropHuntInvisEnabled { get; set; } = true;

    [ModdedToggleOption("Enable Speed Boost")]
    public bool PropHuntSpeedboostEnabled { get; set; } = true;
}
