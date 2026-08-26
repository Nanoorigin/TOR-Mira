using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class JesterRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Jester";
    public override string RoleDescription => "Win by getting voted out.";
    public override string RoleLongDescription => "The Jester wins by getting voted out during a meeting. Use tricks and suspicious behavior to get the crew to vote you out.";
    public override Color RoleColor => new Color32(236, 98, 165, 255);

    public static bool TriggerJesterWin;
    public static bool CanCallEmergency;
    public static bool HasImpostorVision;

    public static void ClearAndReload()
    {
        TriggerJesterWin = false;
        CanCallEmergency = true;
        HasImpostorVision = false;
    }
}
