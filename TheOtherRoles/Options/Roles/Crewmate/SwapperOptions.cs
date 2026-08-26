using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SwapperOptions : AbstractRoleOptionGroup<SwapperRole>
{
    public override string GroupName => "Swapper";

    [ModdedToggleOption("Swapper Can Call Emergency")]
    public bool CanCallEmergency { get; set; } = false;

    [ModdedToggleOption("Swapper Can Only Swap Others")]
    public bool CanOnlySwapOthers { get; set; } = false;

    [ModdedNumberOption("Swap Charges", 0f, 5f, 1f, MiraNumberSuffixes.None)]
    public float SwapCharges { get; set; } = 1f;

    [ModdedNumberOption("Tasks For Recharge", 1f, 10f, 1f, MiraNumberSuffixes.None)]
    public float TasksForRecharge { get; set; } = 2f;
}
