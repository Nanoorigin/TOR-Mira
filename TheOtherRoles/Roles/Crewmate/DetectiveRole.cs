using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class DetectiveRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Detective";
    public string RoleDescription => "The Detective can investigate footprints.";
    public string RoleLongDescription => "The Detective can see footprints left by other players and investigate them to learn information about who was there.";
    public Color RoleColor => new Color32(45, 106, 165, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float FootprintIntervall;
    public static float FootprintDuration;
    public static bool AnonymousFootprints;
    public static float ReportNameDuration;
    public static float ReportColorDuration;

    public static void ClearAndReload()
    {
        Player = null;
        FootprintIntervall = 0.5f;
        FootprintDuration = 5f;
        AnonymousFootprints = false;
        ReportNameDuration = 0f;
        ReportColorDuration = 20f;
    }
}
