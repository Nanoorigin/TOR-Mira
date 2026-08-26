using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class TrapperRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Trapper";
    public string RoleDescription => "The Trapper can place traps.";
    public string RoleLongDescription => "The Trapper can place traps that reveal information about players who walk over them. Traps charge over tasks.";
    public Color RoleColor => new Color32(128, 128, 128, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float Cooldown;
    public static int maxTraps;
    public static int tasksForRecharge;
    public static int triggersToReveal;
    public static bool anonymousMap;
    public static string infoType;
    public static float trapDuration;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        maxTraps = 5;
        tasksForRecharge = 2;
        triggersToReveal = 3;
        anonymousMap = false;
        infoType = "Role";
        trapDuration = 5f;
    }
}
