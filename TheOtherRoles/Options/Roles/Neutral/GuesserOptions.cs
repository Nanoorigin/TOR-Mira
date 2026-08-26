using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Options.Roles.Neutral;

public sealed class GuesserOptions : AbstractRoleOptionGroup<GuesserRole>
{
    public override string GroupName => "Guesser";

    [ModdedNumberOption("Number Of Shots", 1f, 15f, 1f, MiraNumberSuffixes.None)]
    public float NumberOfShots { get; set; } = 2f;

    [ModdedToggleOption("Multiple Shots Per Meeting")]
    public bool MultipleShotsPerMeeting { get; set; } = false;

    [ModdedToggleOption("Kills Through Shield")]
    public bool KillsThroughShield { get; set; } = true;

    [ModdedToggleOption("Evil Can Kill Spy")]
    public bool EvilCanKillSpy { get; set; } = true;

    [ModdedToggleOption("Can Guess Snitch If Tasks Done")]
    public bool CanGuessSnitchIfTasksDone { get; set; } = true;
}
