using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class MediumRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Medium";
    public string RoleDescription => "The Medium can talk to dead players.";
    public string RoleLongDescription => "The Medium can question the souls of dead players to get information about their killer.";
    public Color RoleColor => new Color32(173, 216, 230, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public override bool IsAffectedByComms => false;

    public static PlayerControl Player;
    public static float questioningCooldown;
    public static float questioningDuration;
    public static bool eachSoulOneTimeUse;
    public static int chanceAdditionalInfo;

    public static void ClearAndReload()
    {
        Player = null;
        questioningCooldown = 30f;
        questioningDuration = 3f;
        eachSoulOneTimeUse = false;
        chanceAdditionalInfo = 0;
    }
}
