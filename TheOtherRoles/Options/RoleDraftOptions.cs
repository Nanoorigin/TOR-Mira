using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class RoleDraftOptions : AbstractOptionGroup
{
    public override string GroupName => "Role Draft";

    [ModdedToggleOption("Enable Role Draft")]
    public bool IsDraftMode { get; set; } = false;

    [ModdedNumberOption("Amount Of Choices", 2f, 15f, 1f, MiraNumberSuffixes.None)]
    public float DraftModeAmountOfChoices { get; set; } = 5f;

    [ModdedNumberOption("Time To Choose", 3f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float DraftModeTimeToChoose { get; set; } = 5f;

    [ModdedToggleOption("Show Picked Roles")]
    public bool DraftModeShowRoles { get; set; } = false;

    [ModdedToggleOption("Hide Impostor Roles")]
    public bool DraftModeHideImpRoles { get; set; } = false;

    [ModdedToggleOption("Hide Neutral Roles")]
    public bool DraftModeHideNeutralRoles { get; set; } = false;
}
