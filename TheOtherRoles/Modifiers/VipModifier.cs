using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class VipModifier : GameModifier
{
    public override string ModifierName => "VIP";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<VipOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<VipOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "Shows your team color to all players.";
    }
}

public sealed class VipOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "VIP";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("VIP Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("VIP Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedToggleOption("Show Team Color")]
    public bool ShowTeamColor { get; set; } = true;
}
