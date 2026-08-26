using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Modifiers;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Modifiers;

public sealed class MiniModifier : GameModifier
{
    public override string ModifierName => "Mini";
    public override LoadableAsset<Sprite>? ModifierIcon => null;

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<MiniOptions>.Instance.SpawnRate;
    }

    public override int GetAmountPerGame()
    {
        return 1;
    }

    public override string GetDescription()
    {
        return "You appear smaller and grow over time.";
    }
}

public sealed class MiniOptions : AbstractOptionGroup<BaseModifier>
{
    public override string GroupName => "Mini";
    public override MenuCategory ParentMenu => MenuCategory.Modifiers;

    [ModdedNumberOption("Mini Spawn Rate", 0f, 100f, 10f, MiraNumberSuffixes.Percent, "#")]
    public float SpawnRate { get; set; } = 0f;

    [ModdedNumberOption("Growing Up Duration", 100f, 1500f, 100f, MiraNumberSuffixes.Seconds)]
    public float GrowingUpDuration { get; set; } = 400f;

    [ModdedToggleOption("Grows Up In Meeting")]
    public bool GrowsUpInMeeting { get; set; } = true;
}
