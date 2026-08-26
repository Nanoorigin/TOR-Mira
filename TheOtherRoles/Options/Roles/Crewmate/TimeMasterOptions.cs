using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class TimeMasterOptions : AbstractRoleOptionGroup<TimeMasterRole>
{
    public override string GroupName => "Time Master";

    [ModdedNumberOption("Time Master Cooldown", 10f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("Rewind Time", 1f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float RewindTime { get; set; } = 3f;

    [ModdedNumberOption("Shield Duration", 1f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float ShieldDuration { get; set; } = 3f;
}
