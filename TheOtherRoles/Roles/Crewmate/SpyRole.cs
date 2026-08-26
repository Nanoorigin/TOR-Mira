using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class SpyRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Spy";
    public string RoleDescription => "The Spy appears as an Impostor to the Impostors.";
    public string RoleLongDescription => "The Spy appears as an Impostor to the Impostors, but is actually on the Crewmate team. Impostors may accidentally kill them.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static bool canDieToSheriff;
    public static bool impostorsCanKillAnyone;
    public static bool canEnterVents;
    public static bool hasImpostorVision;

    public static void ClearAndReload()
    {
        Player = null;
        canDieToSheriff = false;
        impostorsCanKillAnyone = true;
        canEnterVents = false;
        hasImpostorVision = false;
    }
}
