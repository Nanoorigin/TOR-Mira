using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class YoyoRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Yo-Yo";
    public string RoleDescription => "The Yo-Yo can blink to marked locations.";
    public string RoleLongDescription => "The Yo-Yo can mark a location and blink back to it. They also have access to an admin table.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float BlinkDuration;
    public static float MarkCooldown;
    public static bool MarkStaysAfterMeeting;
    public static bool HasAdminTable;
    public static float AdminTableCooldown;
    public static float SilhouetteVisibility;

    public static void ClearAndReload()
    {
        Player = null;
        BlinkDuration = 20f;
        MarkCooldown = 20f;
        MarkStaysAfterMeeting = true;
        HasAdminTable = true;
        AdminTableCooldown = 20f;
        SilhouetteVisibility = 0f;
    }
}
