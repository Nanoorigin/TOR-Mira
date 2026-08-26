using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SheriffRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Sheriff";
    public string RoleDescription => "The Sheriff can kill evil players.";
    public string RoleLongDescription => "The Sheriff has a kill button that can kill Impostors and potentially Neutral roles. Killing a Crewmate kills the Sheriff.";
    public Color RoleColor => new Color32(248, 205, 66, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static float Cooldown;
    public static bool CanKillNeutrals;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        Cooldown = 30f;
        CanKillNeutrals = false;
    }
}
