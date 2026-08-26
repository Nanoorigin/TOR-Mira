using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class EngineerRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Engineer";
    public string RoleDescription => "The Engineer can fix sabotages.";
    public string RoleLongDescription => "The Engineer can fix sabotages and use vents. Impostors can see highlighted vents.";
    public Color RoleColor => new Color32(0, 191, 255, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static int NumberOfFixes;
    public static bool ImpostorsSeeVents;
    public static bool JackalSeesVents;

    public static void ClearAndReload()
    {
        Player = null;
        NumberOfFixes = 1;
        ImpostorsSeeVents = true;
        JackalSeesVents = true;
    }
}
