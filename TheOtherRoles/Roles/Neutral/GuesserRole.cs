using UnityEngine;

namespace TheOtherRoles.Roles.Neutral;

public sealed class GuesserRole(IntPtr cppPtr) : NeutralRole(cppPtr)
{
    public override string RoleName => "Guesser";
    public override string RoleDescription => "Guess other players' roles.";
    public override string RoleLongDescription => "The Guesser can guess other players' roles during meetings. If the guess is correct, the target dies. If wrong, the Guesser dies.";
    public override Color RoleColor => new Color32(255, 255, 0, 255);

    public static PlayerControl Player;
    public static int NumberOfShots;
    public static int RemainingShots;
    public static bool MultipleShotsPerMeeting;
    public static bool KillsThroughShield;
    public static bool EvilCanKillSpy;
    public static bool CanGuessSnitchIfTasksDone;

    public static void ClearAndReload()
    {
        Player = null;
        NumberOfShots = 2;
        RemainingShots = 2;
        MultipleShotsPerMeeting = false;
        KillsThroughShield = true;
        EvilCanKillSpy = true;
        CanGuessSnitchIfTasksDone = true;
    }
}
