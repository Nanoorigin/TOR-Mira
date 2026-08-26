using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class PortalmakerRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Portalmaker";
    public string RoleDescription => "The Portalmaker can place portals.";
    public string RoleLongDescription => "The Portalmaker can place two portals that players can use to travel between them. They also have a portal log.";
    public Color RoleColor => new Color32(128, 0, 128, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static float Cooldown;
    public static float usePortalCooldown;
    public static bool logOnlyShowsColorType;
    public static bool logShowsTime;
    public static bool canPortalFromAnywhere;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        usePortalCooldown = 30f;
        logOnlyShowsColorType = true;
        logShowsTime = true;
        canPortalFromAnywhere = true;
    }
}
