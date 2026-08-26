using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class VampireRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Vampire";
    public string RoleDescription => "The Vampire can bite players, killing them after a delay.";
    public string RoleLongDescription => "The Vampire can bite a player, which will kill them after a short delay. The Vampire can also avoid Garlic.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl Bitten;
    public static float KillDelay;
    public static float Cooldown;
    public static bool CanKillNearGarlics;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        Bitten = null;
        KillDelay = 10f;
        Cooldown = 30f;
        CanKillNearGarlics = true;
    }
}
