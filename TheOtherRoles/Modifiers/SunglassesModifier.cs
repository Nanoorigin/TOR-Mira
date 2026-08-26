using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class SunglassesModifier : GameModifier
{
    public override string ModifierName => "Sunglasses";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<SunglassesOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<SunglassesOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "Your vision is reduced.";
    }
}

public sealed class SunglassesOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Sunglasses";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Sunglasses Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Sunglasses Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedNumberOption("Vision Reduction", 10f, 50f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float Vision { get; set; } = 10f;
}
