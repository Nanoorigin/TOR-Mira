using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class TrapperOptions : AbstractRoleOptionGroup<TrapperRole>
{
    public override string GroupName => "Trapper";

    [ModdedNumberOption("Trapper Cooldown", 5f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Max Traps", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float MaxTraps { get; set; } = 5f;

    [ModdedNumberOption("Tasks For Recharge", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float TasksForRecharge { get; set; } = 2f;

    [ModdedNumberOption("Triggers To Reveal", 2f, 10f, 1f, MiraNumberSuffixes.None)]
    public float TriggersToReveal { get; set; } = 3f;

    [ModdedToggleOption("Anonymous Map")]
    public bool AnonymousMap { get; set; } = false;

    [ModdedEnumOption("Info Type", typeof(TrapperInfoTypeOption), ["Role", "Name"])]
    public TrapperInfoTypeOption InfoType { get; set; } = TrapperInfoTypeOption.Role;

    [ModdedNumberOption("Trap Duration", 1f, 15f, 1f, MiraNumberSuffixes.Seconds)]
    public float TrapDuration { get; set; } = 5f;
}

public enum TrapperInfoTypeOption
{
    Role,
    Name
}
