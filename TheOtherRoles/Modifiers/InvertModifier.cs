using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class InvertModifier : GameModifier
{
    public override string ModifierName => "Invert";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<InvertOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<InvertOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "Your controls are inverted for a number of meetings.";
    }
}

public sealed class InvertOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Invert";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Invert Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Invert Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedNumberOption("Meetings Inverted", 1f, 15f, 1f)]
    public float MeetingsInverted { get; set; } = 3f;
}
