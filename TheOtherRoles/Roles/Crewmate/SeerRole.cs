using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SeerRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Seer";
    public string RoleDescription => "The Seer can see souls of dead players.";
    public string RoleLongDescription => "The Seer can see souls of dead players and may get a flash when someone dies.";
    public Color RoleColor => new Color32(194, 177, 117, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static string Mode;
    public static bool limitSoulDuration;
    public static float soulDuration;

    public static void ClearAndReload()
    {
        Player = null;
        Mode = "Flash+Souls";
        limitSoulDuration = false;
        soulDuration = 15f;
    }
}
