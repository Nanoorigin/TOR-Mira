using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class JackalOptions : AbstractRoleOptionGroup<JackalRole>
{
    public override string GroupName => "Jackal";

    [ModdedNumberOption("Jackal Kill Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float KillCooldown { get; set; } = 30f;

    [ModdedNumberOption("Sidekick Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float SidekickCooldown { get; set; } = 30f;

    [ModdedToggleOption("Jackal Can Use Vents")]
    public bool CanUseVents { get; set; } = true;

    [ModdedToggleOption("Jackal Can Sabotage Lights")]
    public bool CanSabotageLights { get; set; } = true;

    [ModdedToggleOption("Can Create Sidekick")]
    public bool CanCreateSidekick { get; set; } = false;

    [ModdedToggleOption("Sidekick Promotes To Jackal")]
    public bool SidekickPromotesToJackal { get; set; } = false;

    [ModdedToggleOption("Sidekick Can Kill")]
    public bool SidekickCanKill { get; set; } = false;

    [ModdedToggleOption("Sidekick Can Use Vents")]
    public bool SidekickCanUseVents { get; set; } = true;

    [ModdedToggleOption("Sidekick Can Sabotage Lights")]
    public bool SidekickCanSabotageLights { get; set; } = true;

    [ModdedToggleOption("Promoted From SK Can Create SK")]
    public bool PromotedFromSKCanCreateSK { get; set; } = true;

    [ModdedToggleOption("Can Make Impostor Sidekick")]
    public bool CanMakeImpostorSidekick { get; set; } = true;

    [ModdedToggleOption("Jackal Has Impostor Vision")]
    public bool HasImpostorVision { get; set; } = false;
}
