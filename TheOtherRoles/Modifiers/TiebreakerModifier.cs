using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class TiebreakerModifier : GameModifier
{
    public override string ModifierName => "Tiebreaker";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<TiebreakerOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return 1;
    }

    public override string GetDescription()
    {
        return "If a vote is tied, your vote counts as the tiebreaker.";
    }
}

public sealed class TiebreakerOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Tiebreaker";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Tiebreaker Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;
}
