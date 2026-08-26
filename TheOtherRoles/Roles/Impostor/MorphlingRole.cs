using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles.Impostor;

public sealed class MorphlingRole(IntPtr cppPtr) : ImpostorRole(cppPtr), ICustomRole
{
    public string RoleName => "Morphling";
    public string RoleDescription => "The Morphling can disguise as another player.";
    public string RoleLongDescription => "The Morphling can sample a player's appearance and later morph into them, hiding their true identity.";
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this) { CanGetKilled = false, UseVanillaKillButton = true, CanUseVent = true, CanUseSabotage = true };

    public static PlayerControl Player;
    public static PlayerControl SampledTarget;
    public static PlayerControl MorphTarget;
    public static float Cooldown;
    public static float MorphDuration;
    public static float Timer;

    public static void ClearAndReload()
    {
        Player = null;
        SampledTarget = null;
        MorphTarget = null;
        Cooldown = 30f;
        MorphDuration = 10f;
        Timer = 0f;
    }
}
