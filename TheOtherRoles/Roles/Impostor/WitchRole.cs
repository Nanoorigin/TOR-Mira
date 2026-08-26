using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class WitchRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Witch";
    public string RoleDescription => "The Witch can spell players to control them.";
    public string RoleLongDescription => "The Witch can cast spells on players. Spelled players can be vote-killed by the Witch during meetings.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static List<PlayerControl> SpelledPlayers = new();
    public static float SpellCooldown;
    public static float AdditionalCooldown;
    public static bool CanSpellAnyone;
    public static float SpellDuration;
    public static bool TriggerBothCooldowns;
    public static bool VoteSavesTarget;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        SpelledPlayers = new List<PlayerControl>();
        SpellCooldown = 30f;
        AdditionalCooldown = 10f;
        CanSpellAnyone = false;
        SpellDuration = 1f;
        TriggerBothCooldowns = true;
        VoteSavesTarget = true;
    }
}
