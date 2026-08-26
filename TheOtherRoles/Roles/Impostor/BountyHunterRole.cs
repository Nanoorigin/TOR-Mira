using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class BountyHunterRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Bounty Hunter";
    public string RoleDescription => "The Bounty Hunter has a bounty target to kill.";
    public string RoleLongDescription => "The Bounty Hunter gets a bounty target. Killing the target reduces the kill cooldown. Killing others increases it.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl BountyTarget;
    public static float BountyDuration;
    public static float ReducedCooldown;
    public static float PunishmentTime;
    public static bool ShowArrow;
    public static float ArrowUpdateInterval;
    public static float Timer;

    public static void ClearAndReload()
    {
        Player = null;
        BountyTarget = null;
        BountyDuration = 60f;
        ReducedCooldown = 2.5f;
        PunishmentTime = 20f;
        ShowArrow = true;
        ArrowUpdateInterval = 15f;
        Timer = 0f;
    }
}
