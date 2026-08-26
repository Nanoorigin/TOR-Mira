using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class DeputyOptions : AbstractRoleOptionGroup<DeputyRole>
{
    public override string GroupName => "Deputy";

    [ModdedNumberOption("Handcuffs", 1f, 10f, 1f, MiraNumberSuffixes.None)]
    public float Handcuffs { get; set; } = 3f;

    [ModdedNumberOption("Deputy Cooldown", 10f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Handcuff Duration", 5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Duration { get; set; } = 15f;
}
