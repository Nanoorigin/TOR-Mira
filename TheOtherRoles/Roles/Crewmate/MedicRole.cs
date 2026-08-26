using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public sealed class MedicRole(IntPtr cppPtr) : CrewmateRole(cppPtr), ICustomRole
{
    public string RoleName => "Medic";
    public string RoleDescription => "The Medic can shield a player.";
    public string RoleLongDescription => "The Medic can protect a player with a shield. If the shielded player is attacked, the Medic gets a flash alert.";
    public Color RoleColor => new Color32(185, 105, 200, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = true, TasksCountForProgress = true };

    public static PlayerControl Player;
    public static PlayerControl Shielded;
    public static PlayerControl currentTarget;
    public static string ShowShielded;
    public static bool ShowAttemptToShielded;
    public static string ShieldWillBe;
    public static bool ShowAttemptToMedic;
    public static bool usedShield;

    public static void ClearAndReload()
    {
        Player = null;
        Shielded = null;
        currentTarget = null;
        ShowShielded = "Everyone";
        ShowAttemptToShielded = false;
        ShieldWillBe = "Instantly";
        ShowAttemptToMedic = false;
        usedShield = false;
    }
}
