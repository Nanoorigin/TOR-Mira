using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class TrackerRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Tracker";
    public string RoleDescription => "The Tracker can track players.";
    public string RoleLongDescription => "The Tracker can track a player's location with an arrow, and may also track corpses.";
    public Color RoleColor => new Color32(140, 170, 45, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static float UpdateInterval;
    public static bool ResetTargetAfterMeeting;
    public static bool canTrackCorpses;
    public static float corpsesCooldown;
    public static float corpsesDuration;
    public static string trackingMethod;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        UpdateInterval = 5f;
        ResetTargetAfterMeeting = false;
        canTrackCorpses = true;
        corpsesCooldown = 30f;
        corpsesDuration = 5f;
        trackingMethod = "Arrow Only";
    }
}
