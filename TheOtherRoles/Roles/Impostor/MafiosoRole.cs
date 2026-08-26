using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class MafiosoRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Mafioso";
    public string RoleDescription => "The Mafioso follows the Godfather's orders.";
    public string RoleLongDescription => "The Mafioso kills for the Godfather. If the Godfather dies, the Mafioso becomes a regular Impostor.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = false, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;

    public static void ClearAndReload()
    {
        Player = null;
    }
}
