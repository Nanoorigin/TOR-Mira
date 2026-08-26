using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SheriffOptions : AbstractRoleOptionGroup<SheriffRole>
{
    public override string GroupName => "Sheriff";

    [ModdedNumberOption("Sheriff Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedToggleOption("Sheriff Can Kill Neutrals")]
    public bool CanKillNeutrals { get; set; } = false;
}
