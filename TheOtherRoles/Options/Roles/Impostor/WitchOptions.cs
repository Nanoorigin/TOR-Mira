using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Impostor;

namespace TheOtherRoles.Options.Roles.Impostor;

public sealed class WitchOptions : AbstractRoleOptionGroup<WitchRole>
{
    public override string GroupName => "Witch";

    [ModdedNumberOption("Spell Cooldown", 10f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float SpellCooldown { get; set; } = 30f;

    [ModdedNumberOption("Additional Cooldown", 0f, 60f, 5f, MiraNumberSuffixes.Seconds)]
    public float AdditionalCooldown { get; set; } = 10f;

    [ModdedToggleOption("Witch Can Spell Anyone")]
    public bool CanSpellAnyone { get; set; } = false;

    [ModdedNumberOption("Spell Duration", 0f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float SpellDuration { get; set; } = 1f;

    [ModdedToggleOption("Trigger Both Cooldowns")]
    public bool TriggerBothCooldowns { get; set; } = true;

    [ModdedToggleOption("Vote Saves Target")]
    public bool VoteSavesTarget { get; set; } = true;
}
