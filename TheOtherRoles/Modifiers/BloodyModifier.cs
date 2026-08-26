using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class BloodyModifier : GameModifier
{
    public override string ModifierName => "Bloody";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<BloodyOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<BloodyOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "Leaves a blood trail for a duration after you die.";
    }
}

public sealed class BloodyOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Bloody";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Bloody Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Bloody Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedNumberOption("Trail Duration", 3f, 60f, 1f, MiraNumberSuffixes.Seconds)]
    public float TrailDuration { get; set; } = 10f;
}
