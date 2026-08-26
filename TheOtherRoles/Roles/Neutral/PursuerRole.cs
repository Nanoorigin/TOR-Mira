using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class PursuerRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Pursuer";
    public override string RoleDescription => "Defend your client by any means.";
    public override string RoleLongDescription => "The Pursuer is a variant of the Lawyer that can use blank bullets to protect their client.";
    public override Color RoleColor => new Color32(175, 135, 55, 255);

    public static PlayerControl Player;
    public static PlayerControl Target;
    public static float BlankCooldown;
    public static int BlanksNumber;
    public static int BlanksUsed;

    public static void ClearAndReload()
    {
        Player = null;
        Target = null;
        BlankCooldown = 30f;
        BlanksNumber = 5;
        BlanksUsed = 0;
    }
}
