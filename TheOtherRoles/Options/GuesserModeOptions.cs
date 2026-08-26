using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class GuesserModeOptions : AbstractOptionGroup
{
    public override string GroupName => "Guesser Mode";

    [ModdedNumberOption("Crew Number", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float GuesserGamemodeCrewNumber { get; set; } = 5f;

    [ModdedNumberOption("Neutral Number", 0f, 15f, 1f, MiraNumberSuffixes.None)]
    public float GuesserGamemodeNeutralNumber { get; set; } = 3f;

    [ModdedNumberOption("Impostor Number", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float GuesserGamemodeImpNumber { get; set; } = 1f;

    [ModdedNumberOption("Number Of Shots", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float GuesserGamemodeNumberOfShots { get; set; } = 3f;

    [ModdedToggleOption("Has Multiple Shots Per Meeting")]
    public bool GuesserGamemodeHasMultipleShotsPerMeeting { get; set; } = false;

    [ModdedToggleOption("Kills Through Shield")]
    public bool GuesserGamemodeKillsThroughShield { get; set; } = true;

    [ModdedToggleOption("Evil Can Kill Spy")]
    public bool GuesserGamemodeEvilCanKillSpy { get; set; } = true;

    [ModdedToggleOption("Can't Guess Snitch If Tasks Done")]
    public bool GuesserGamemodeCantGuessSnitchIfTasksDone { get; set; } = true;
}
