using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class MedicOptions : AbstractRoleOptionGroup<MedicRole>
{
    public override string GroupName => "Medic";

    [ModdedEnumOption("Show Shielded", typeof(MedicShowShieldedOption), ["Everyone", "Shielded + Medic", "Medic Only"])]
    public MedicShowShieldedOption ShowShielded { get; set; } = MedicShowShieldedOption.Everyone;

    [ModdedToggleOption("Show Attempt To Shielded")]
    public bool ShowAttemptToShielded { get; set; } = false;

    [ModdedEnumOption("Shield Will Be", typeof(MedicShieldWillBeOption), ["Instantly", "After Meeting"])]
    public MedicShieldWillBeOption ShieldWillBe { get; set; } = MedicShieldWillBeOption.Instantly;

    [ModdedToggleOption("Show Attempt To Medic")]
    public bool ShowAttemptToMedic { get; set; } = false;
}

public enum MedicShowShieldedOption
{
    Everyone,
    ShieldedMedic,
    MedicOnly
}

public enum MedicShieldWillBeOption
{
    Instantly,
    AfterMeeting
}
