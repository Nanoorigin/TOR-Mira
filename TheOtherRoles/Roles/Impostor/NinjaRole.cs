using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class NinjaRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Ninja";
    public string RoleDescription => "The Ninja can mark and teleport to players.";
    public string RoleLongDescription => "The Ninja can mark a player and later teleport to their location, leaving a trace behind.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl MarkTarget;
    public static float MarkCooldown;
    public static bool KnowsTargetLocation;
    public static float TraceDuration;
    public static float TraceColorFadeTime;
    public static float InvisibleDuration;

    public static void ClearAndReload()
    {
        Player = null;
        MarkTarget = null;
        MarkCooldown = 30f;
        KnowsTargetLocation = true;
        TraceDuration = 5f;
        TraceColorFadeTime = 2f;
        InvisibleDuration = 3f;
    }
}
