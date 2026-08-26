using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class DeputyRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Deputy";
    public string RoleDescription => "The Deputy is the Sheriff's right hand.";
    public string RoleLongDescription => "The Deputy can handcuff players, preventing them from using abilities. The Deputy may be promoted to Sheriff.";
    public Color RoleColor => new Color32(248, 205, 66, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl Handcuffed;
    public static int Handcuffs;
    public static float Cooldown;
    public static float Duration;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        Handcuffed = null;
        Handcuffs = 3;
        Cooldown = 30f;
        Duration = 15f;
    }
}
