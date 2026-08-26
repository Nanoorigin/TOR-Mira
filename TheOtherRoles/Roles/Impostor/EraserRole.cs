using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class EraserRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Eraser";
    public string RoleDescription => "The Eraser can erase a player's role.";
    public string RoleLongDescription => "The Eraser can erase a player's role, turning them into a regular Crewmate. The erasure happens at the next meeting.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl EraseTarget;
    public static float Cooldown;
    public static bool CanEraseAnyone;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        EraseTarget = null;
        Cooldown = 30f;
        CanEraseAnyone = false;
    }
}
