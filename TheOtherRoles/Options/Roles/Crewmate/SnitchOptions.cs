using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SnitchOptions : AbstractRoleOptionGroup<SnitchRole>
{
    public override string GroupName => "Snitch";

    [ModdedNumberOption("Tasks Left For Reveal", 0f, 25f, 1f, MiraNumberSuffixes.None)]
    public float TasksLeftForReveal { get; set; } = 5f;

    [ModdedEnumOption("Information Mode", typeof(SnitchInformationModeOption), ["Chat", "Tasks"])]
    public SnitchInformationModeOption InformationMode { get; set; } = SnitchInformationModeOption.Chat;

    [ModdedEnumOption("Targets", typeof(SnitchTargetsOption), ["All Evil Players", "Impostors Only"])]
    public SnitchTargetsOption Targets { get; set; } = SnitchTargetsOption.AllEvilPlayers;
}

public enum SnitchInformationModeOption
{
    Chat,
    Tasks
}

public enum SnitchTargetsOption
{
    AllEvilPlayers,
    ImpostorsOnly
}
