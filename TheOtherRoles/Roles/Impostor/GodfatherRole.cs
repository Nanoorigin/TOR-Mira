using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class GodfatherRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Godfather";
    public string RoleDescription => "The Godfather leads the Mafia, assigning tasks to the Mafioso.";
    public string RoleLongDescription => "The Godfather is the leader of the Mafia. The Mafioso follows the Godfather's orders and kills for them.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl Mafioso;

    public static void ClearAndReload()
    {
        Player = null;
        Mafioso = null;
    }
}
