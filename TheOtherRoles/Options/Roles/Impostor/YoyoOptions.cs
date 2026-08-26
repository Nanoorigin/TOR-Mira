using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class YoyoOptions : AbstractRoleOptionGroup<YoyoRole>
{
    public override string GroupName => "Yoyo";

    [ModdedNumberOption("Blink Duration", 2.5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float BlinkDuration { get; set; } = 20f;

    [ModdedNumberOption("Mark Cooldown", 2.5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float MarkCooldown { get; set; } = 20f;

    [ModdedToggleOption("Mark Stays After Meeting")]
    public bool MarkStaysAfterMeeting { get; set; } = true;

    [ModdedToggleOption("Has Admin Table")]
    public bool HasAdminTable { get; set; } = true;

    [ModdedNumberOption("Admin Table Cooldown", 2.5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float AdminTableCooldown { get; set; } = 20f;

    [ModdedNumberOption("Silhouette Visibility", 0f, 0.5f, 0.1f, MiraNumberSuffixes.Multiplier)]
    public float SilhouetteVisibility { get; set; } = 0f;
}
