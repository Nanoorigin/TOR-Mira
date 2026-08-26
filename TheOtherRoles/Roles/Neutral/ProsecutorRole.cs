using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class ProsecutorRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Prosecutor";
    public override string RoleDescription => "Prosecute players during meetings.";
    public override string RoleLongDescription => "The Prosecutor can prosecute players during meetings, potentially exposing their role or having them voted out.";
    public override Color RoleColor => new Color32(255, 152, 37, 255);

    public static PlayerControl Prosecuted;
    public static bool CanProsecute;

    public static void ClearAndReload()
    {
        Prosecuted = null;
        CanProsecute = false;
    }
}
