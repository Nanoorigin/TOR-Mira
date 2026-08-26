using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class LawyerRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Lawyer";
    public override string RoleDescription => "Defend your client.";
    public override string RoleLongDescription => "The Lawyer must defend their client. If the client is voted out, the Lawyer wins. The Lawyer may be a Prosecutor.";
    public override Color RoleColor => new Color32(175, 135, 55, 255);

    public static PlayerControl Player;
    public static PlayerControl Target;
    public static float Vision;
    public static bool KnowsTargetRole;
    public static bool CanCallEmergency;
    public static bool TargetCanBeJester;
    public static bool isProsecutor;
    public static float BlankCooldown;
    public static int BlanksNumber;

    public static void ClearAndReload()
    {
        Player = null;
        Target = null;
        Vision = 1f;
        KnowsTargetRole = false;
        CanCallEmergency = true;
        TargetCanBeJester = false;
        isProsecutor = false;
        BlankCooldown = 30f;
        BlanksNumber = 5;
    }
}
