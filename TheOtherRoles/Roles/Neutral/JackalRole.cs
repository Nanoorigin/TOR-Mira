using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class JackalRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Jackal";
    public override string RoleDescription => "Kill everyone to win.";
    public override string RoleLongDescription => "The Jackal is a neutral killer who wins by being the last one standing. They can create a Sidekick to help them.";
    public override Color RoleColor => new Color32(0, 171, 226, 255);

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl Sidekick;
    public static float KillCooldown;
    public static float SidekickCooldown;
    public static bool CanUseVents;
    public static bool CanSabotageLights;
    public static bool CanCreateSidekick;
    public static bool SidekickPromotesToJackal;
    public static bool SidekickCanKill;
    public static bool SidekickCanUseVents;
    public static bool SidekickCanSabotageLights;
    public static bool PromotedFromSKCanCreateSK;
    public static bool CanMakeImpostorSidekick;
    public static bool HasImpostorVision;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        Sidekick = null;
        KillCooldown = 30f;
        SidekickCooldown = 30f;
        CanUseVents = true;
        CanSabotageLights = true;
        CanCreateSidekick = false;
        SidekickPromotesToJackal = false;
        SidekickCanKill = false;
        SidekickCanUseVents = true;
        SidekickCanSabotageLights = true;
        PromotedFromSKCanCreateSK = true;
        CanMakeImpostorSidekick = true;
        HasImpostorVision = false;
    }
}
