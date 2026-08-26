using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class WarlockRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Warlock";
    public string RoleDescription => "Curse players to lock their abilities.";
    public string RoleLongDescription => "The Warlock can curse a player, locking their abilities and preventing them from using any special actions for a duration.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl CurseVictim;
    public static PlayerControl CurseVictimTarget;
    public static float Cooldown;
    public static float RootTime;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        CurseVictim = null;
        CurseVictimTarget = null;
        Cooldown = 30f;
        RootTime = 5f;
    }
}
