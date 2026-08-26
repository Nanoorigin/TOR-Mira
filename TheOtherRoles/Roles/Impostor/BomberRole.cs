using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class BomberRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Bomber";
    public string RoleDescription => "The Bomber can place bombs.";
    public string RoleLongDescription => "The Bomber can place bombs that explode after a timer, killing players in range. Crewmates can defuse them.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float DestructionTime;
    public static float DestructionRange;
    public static float HearRange;
    public static float DefuseDuration;
    public static float Cooldown;
    public static float ActiveAfter;

    public static void ClearAndReload()
    {
        Player = null;
        DestructionTime = 20f;
        DestructionRange = 50f;
        HearRange = 60f;
        DefuseDuration = 3f;
        Cooldown = 15f;
        ActiveAfter = 3f;
    }
}
