using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class TimeMasterRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Time Master";
    public string RoleDescription => "The Time Master can rewind time.";
    public string RoleLongDescription => "The Time Master can activate a time shield that rewinds their position if they die while the shield is active.";
    public Color RoleColor => new Color32(0, 191, 255, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float Cooldown;
    public static float RewindTime;
    public static float ShieldDuration;
    public static bool timeShieldActive;
    public static Vector3 rewindPosition;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        RewindTime = 3f;
        ShieldDuration = 3f;
        timeShieldActive = false;
        rewindPosition = Vector3.zero;
    }
}
