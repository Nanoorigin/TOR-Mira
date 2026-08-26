using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class TricksterRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Trickster";
    public string RoleDescription => "The Trickster uses boxes and lights to confuse crewmates.";
    public string RoleLongDescription => "The Trickster can place Jack-In-The-Boxes that create confusion and toggle lights to blind crewmates.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float BoxCooldown;
    public static float LightsOutCooldown;
    public static float LightsOutDuration;

    public static void ClearAndReload()
    {
        Player = null;
        BoxCooldown = 10f;
        LightsOutCooldown = 30f;
        LightsOutDuration = 15f;
    }
}
