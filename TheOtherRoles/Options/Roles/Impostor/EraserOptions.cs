using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class EraserOptions : AbstractRoleOptionGroup<EraserRole>
{
    public override string GroupName => "Eraser";

    [ModdedNumberOption("Eraser Cooldown", 10f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedToggleOption("Eraser Can Erase Anyone")]
    public bool CanEraseAnyone { get; set; } = false;
}
