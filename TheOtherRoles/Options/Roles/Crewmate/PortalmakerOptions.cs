using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class PortalmakerOptions : AbstractRoleOptionGroup<PortalmakerRole>
{
    public override string GroupName => "Portalmaker";

    [ModdedNumberOption("Portalmaker Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Use Portal Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float UsePortalCooldown { get; set; } = 30f;

    [ModdedToggleOption("Log Only Shows Color Type")]
    public bool LogOnlyShowsColorType { get; set; } = true;

    [ModdedToggleOption("Log Shows Time")]
    public bool LogShowsTime { get; set; } = true;

    [ModdedToggleOption("Can Portal From Anywhere")]
    public bool CanPortalFromAnywhere { get; set; } = true;
}
