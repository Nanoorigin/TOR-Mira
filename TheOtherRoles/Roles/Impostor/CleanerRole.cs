using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class CleanerRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Cleaner";
    public string RoleDescription => "The Cleaner can clean dead bodies.";
    public string RoleLongDescription => "The Cleaner can clean up dead bodies, making them disappear so they cannot be reported.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float Cooldown;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
    }
}
