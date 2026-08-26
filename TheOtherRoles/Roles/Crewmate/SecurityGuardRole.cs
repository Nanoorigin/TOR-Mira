using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SecurityGuardRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Security Guard";
    public string RoleDescription => "The Security Guard can seal vents and place cameras.";
    public string RoleLongDescription => "The Security Guard can seal vents and place cameras using screws. They have a gadget with charges that recharge over tasks.";
    public Color RoleColor => new Color32(194, 177, 117, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float Cooldown;
    public static int totalScrews;
    public static int screwsPerCam;
    public static int screwsPerVent;
    public static float camDuration;
    public static int maxCharges;
    public static int tasksForRecharge;
    public static int charges;
    public static bool canMoveDuringDuration;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        totalScrews = 7;
        screwsPerCam = 2;
        screwsPerVent = 1;
        camDuration = 10f;
        maxCharges = 5;
        tasksForRecharge = 3;
        charges = 0;
        canMoveDuringDuration = true;
    }
}
