using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class SidekickRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Sidekick";
    public override string RoleDescription => "Help the Jackal.";
    public override string RoleLongDescription => "The Sidekick is created by the Jackal. They work together to eliminate all other players. If the Jackal dies, the Sidekick may be promoted.";
    public override Color RoleColor => new Color32(0, 171, 226, 255);

    public static PlayerControl Player;
    public static PlayerControl CurrentTarget;
    public static PlayerControl Jackal;

    public static void ClearAndReload()
    {
        Player = null;
        CurrentTarget = null;
        Jackal = null;
    }
}
