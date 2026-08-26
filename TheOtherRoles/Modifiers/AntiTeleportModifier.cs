using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class AntiTeleportModifier : GameModifier
{
    public override string ModifierName => "Anti-Teleport";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<AntiTeleportOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<AntiTeleportOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "Teleports to a random location when a meeting ends.";
    }
}

public sealed class AntiTeleportOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Anti-Teleport";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Anti-Teleport Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Anti-Teleport Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;
}
