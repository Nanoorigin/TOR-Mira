using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class HackerRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Hacker";
    public string RoleDescription => "The Hacker can hack devices.";
    public string RoleLongDescription => "The Hacker can use the admin table and vital signs monitor remotely, and may have a gadget with charges.";
    public Color RoleColor => new Color32(0, 200, 0, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float Cooldown;
    public static float Duration;
    public static bool onlySeesColorType;
    public static int maxCharges;
    public static int tasksForRecharge;
    public static int charges;
    public static bool canMoveDuringDuration;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        Duration = 10f;
        onlySeesColorType = false;
        maxCharges = 5;
        tasksForRecharge = 2;
        charges = 0;
        canMoveDuringDuration = true;
    }
}
