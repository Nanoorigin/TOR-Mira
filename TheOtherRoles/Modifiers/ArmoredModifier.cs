using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class ArmoredModifier : GameModifier
{
    public override string ModifierName => "Armored";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<ArmoredOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return 1;
    }

    public override string GetDescription()
    {
        return "You can survive one kill attempt.";
    }
}

public sealed class ArmoredOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Armored";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Armored Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;
}
