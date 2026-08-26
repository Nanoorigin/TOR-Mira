using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class MayorRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Mayor";
    public string RoleDescription => "The Mayor can see vote colors and has a mobile emergency button.";
    public string RoleLongDescription => "The Mayor can use a mobile emergency button and has additional votes. They may also see vote colors after completing tasks.";
    public Color RoleColor => new Color32(128, 0, 128, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static bool CanSeeVoteColors;
    public static int TasksNeededToSeeVoteColors;
    public static bool MobileEmergencyButton;
    public static int NumberOfRemoteMeetings;
    public static int Votes;

    public static void ClearAndReload()
    {
        Player = null;
        CanSeeVoteColors = false;
        TasksNeededToSeeVoteColors = 5;
        MobileEmergencyButton = true;
        NumberOfRemoteMeetings = 1;
        Votes = 1;
    }
}
