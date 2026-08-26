using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class LoversModifier : GameModifier
{
    public static PlayerControl? Lover1;
    public static PlayerControl? Lover2;

    public override string ModifierName => "Lovers";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<LoversModifierOption>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return 2;
    }

    public override string GetDescription()
    {
        return "Two players are linked; when one dies, the other dies too.";
    }
}

public sealed class LoversModifierOption : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Lovers";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Lovers Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Chance Impostor Lover", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float ChanceImpostorLover { get; set; } = 0f;

    [ModdedToggleOption("Both Die")]
    public bool BothDie { get; set; } = true;

    [ModdedToggleOption("Enable Chat")]
    public bool EnableChat { get; set; } = true;
}
