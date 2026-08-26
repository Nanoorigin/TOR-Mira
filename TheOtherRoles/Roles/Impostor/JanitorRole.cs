using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class JanitorRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Janitor";
    public string RoleDescription => "The Janitor cleans up evidence.";
    public string RoleLongDescription => "The Janitor can clean dead bodies, removing them from the game. The Janitor works with the Godfather and Mafioso.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = false, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float Cooldown;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
    }
}
