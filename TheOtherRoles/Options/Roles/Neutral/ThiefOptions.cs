using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class ThiefOptions : AbstractRoleOptionGroup<ThiefRole>
{
    public override string GroupName => "Thief";

    [ModdedNumberOption("Thief Cooldown", 5f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedToggleOption("Thief Can Kill Sheriff")]
    public bool CanKillSheriff { get; set; } = true;

    [ModdedToggleOption("Thief Has Impostor Vision")]
    public bool HasImpostorVision { get; set; } = true;

    [ModdedToggleOption("Thief Can Use Vents")]
    public bool CanUseVents { get; set; } = true;

    [ModdedToggleOption("Can Steal With Guess")]
    public bool CanStealWithGuess { get; set; } = false;
}
