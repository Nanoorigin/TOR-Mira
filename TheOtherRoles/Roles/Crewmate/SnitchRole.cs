using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SnitchRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Snitch";
    public string RoleDescription => "The Snitch can identify evil players.";
    public string RoleLongDescription => "The Snitch can reveal the identity of evil players through chat messages or map arrows when they complete their tasks.";
    public Color RoleColor => new Color32(173, 216, 230, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static int tasksLeftForReveal;
    public static string informationMode;
    public static string targets;

    public static void ClearAndReload()
    {
        Player = null;
        tasksLeftForReveal = 5;
        informationMode = "Chat";
        targets = "All Evil Players";
    }
}
