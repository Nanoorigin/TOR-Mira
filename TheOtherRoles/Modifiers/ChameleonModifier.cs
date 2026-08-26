using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class ChameleonModifier : GameModifier
{
    public override string ModifierName => "Chameleon";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<ChameleonOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<ChameleonOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "You fade and become invisible when standing still.";
    }
}

public sealed class ChameleonOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Chameleon";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Chameleon Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Chameleon Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedNumberOption("Time Until Fading", 1f, 10f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float TimeUntilFading { get; set; } = 3f;

    [ModdedNumberOption("Fade Duration", 0.25f, 10f, 0.25f, MiraNumberSuffixes.Seconds)]
    public float FadeDuration { get; set; } = 1f;

    [ModdedNumberOption("Minimum Visibility", 0f, 50f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float MinimumVisibility { get; set; } = 0f;
}
