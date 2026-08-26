using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class VultureRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Vulture";
    public override string RoleDescription => "Eat corpses to win.";
    public override string RoleLongDescription => "The Vulture must eat a certain number of corpses to win. Use arrows to locate corpses.";
    public override Color RoleColor => new Color32(139, 69, 19, 255);

    public static PlayerControl Player;
    public static float Cooldown;
    public static int CorpsesNeeded;
    public static bool CanUseVents;
    public static bool ShowArrows;
    public static int EatenCorpseCount;

    public static void ClearAndReload()
    {
        Player = null;
        Cooldown = 15f;
        CorpsesNeeded = 4;
        CanUseVents = true;
        ShowArrows = true;
        EatenCorpseCount = 0;
    }
}
