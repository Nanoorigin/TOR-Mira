using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class ThiefRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Thief";
    public override string RoleDescription => "Steal the ability of another role.";
    public override string RoleLongDescription => "The Thief can steal the role of another player by killing them, becoming that role. The Thief can also steal with a guess.";
    public override Color RoleColor => new Color32(114, 48, 168, 255);

    public static PlayerControl Player;
    public static float Cooldown;
    public static bool CanKillSheriff;
    public static bool HasImpostorVision;
    public static bool CanUseVents;
    public static bool CanStealWithGuess;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 30f;
        CanKillSheriff = true;
        HasImpostorVision = true;
        CanUseVents = true;
        CanStealWithGuess = false;
    }
}
