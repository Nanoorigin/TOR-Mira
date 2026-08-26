using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class ArsonistRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Arsonist";
    public override string RoleDescription => "Douse players and ignite them to win.";
    public override string RoleLongDescription => "The Arsonist can douse players with oil. When all alive players are doused, the Arsonist can ignite them to win.";
    public override Color RoleColor => new Color32(255, 0, 0, 255);

    public static PlayerControl Player;
    public static PlayerControl CurrentDouseTarget;
    public static float Cooldown;
    public static float DouseDuration;
    public static List<PlayerControl> DousedPlayers = new();

    public static void ClearAndReload()
    {
        Player = null;
        CurrentDouseTarget = null;
        Cooldown = 12.5f;
        DouseDuration = 3f;
        DousedPlayers = new List<PlayerControl>();
    }
}
