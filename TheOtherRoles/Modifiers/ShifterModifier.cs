using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class ShifterModifier : GameModifier
{
    public override string ModifierName => "Shifter";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<ShifterOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return 1;
    }

    public override string GetDescription()
    {
        return "You can shift roles with other players.";
    }
}

public sealed class ShifterOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Shifter";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Shifter Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedToggleOption("Can Shift Medic Shield")]
    public bool CanShiftMedicShield { get; set; } = false;
}
