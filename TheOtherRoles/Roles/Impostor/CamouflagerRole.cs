using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class CamouflagerRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Camouflager";
    public string RoleDescription => "The Camouflager can hide everyone's identity.";
    public string RoleLongDescription => "The Camouflager can activate camouflage, making all players appear as unknown. Names, colors, and hats are hidden.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static float Cooldown;
    public static float CamoDuration;
    public static float Timer;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        CamoDuration = 10f;
        Timer = 0f;
    }
}
