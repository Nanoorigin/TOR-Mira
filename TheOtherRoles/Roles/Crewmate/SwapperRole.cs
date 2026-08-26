using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SwapperRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Swapper";
    public string RoleDescription => "The Swapper can swap votes.";
    public string RoleLongDescription => "The Swapper can swap two players' votes during a meeting, redirecting votes to different targets.";
    public Color RoleColor => new Color32(204, 255, 153, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static PlayerControl Swapper1;
    public static PlayerControl Swapper2;
    public static bool canCallEmergency;
    public static bool canOnlySwapOthers;
    public static int swapCharges;
    public static int tasksForRecharge;

    public static void ClearAndReload()
    {
        Player = null;
        Swapper1 = null;
        Swapper2 = null;
        canCallEmergency = false;
        canOnlySwapOthers = false;
        swapCharges = 1;
        tasksForRecharge = 2;
    }
}
