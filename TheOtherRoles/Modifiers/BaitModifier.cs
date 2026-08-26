using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class BaitModifier : GameModifier
{
    public override string ModifierName => "Bait";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<BaitOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<BaitOptions>.Instance.Quantity;
    }

    public override string GetDescription()
    {
        return "When you are killed, the killer is forced to self-report.";
    }
}

public sealed class BaitOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Bait";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Bait Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Bait Quantity", 1f, 15f, 1f)]
    public float Quantity { get; set; } = 1f;

    [ModdedNumberOption("Report Delay Min", 0f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float ReportDelayMin { get; set; } = 0f;

    [ModdedNumberOption("Report Delay Max", 0f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float ReportDelayMax { get; set; } = 0f;

    [ModdedToggleOption("Show Kill Flash")]
    public bool ShowKillFlash { get; set; } = true;
}
