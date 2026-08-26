using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class LighterRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Lighter";
    public string RoleDescription => "The Lighter can see better in the dark.";
    public string RoleLongDescription => "The Lighter has increased vision when lights are sabotaged and can use a flashlight.";
    public Color RoleColor => new Color32(250, 250, 105, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float VisionOnLightsOn;
    public static float VisionOnLightsOff;
    public static float FlashlightWidth;

    public static void ClearAndReload()
    {
        Player = null;
        VisionOnLightsOn = 1.5f;
        VisionOnLightsOff = 0.5f;
        FlashlightWidth = 0.3f;
    }
}
