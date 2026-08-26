using MiraAPI.GameModes;

namespace TheOtherRoles.GameModes;

public class GuesserGM : CustomGameMode
{
    public override string Name => "Guesser";
    public override string Description => "Everyone becomes a Guesser";
    public override int Id => 1;

    public override void CheckGameEnd(out bool runOriginal, LogicGameFlowNormal instance)
    {
        runOriginal = true;
    }

    public override void AssignRoles(out bool runOriginal, LogicRoleSelectionNormal instance)
    {
        runOriginal = true;
    }

    public override bool AreRoleSettingsEnabled()
    {
        return false;
    }

    // Stub methods for HandleGuesser integration - TODO: implement properly
    private static System.Collections.Generic.Dictionary<byte, int> remainingShotsMap = new();

    public static bool isGuesser(byte playerId)
    {
        return remainingShotsMap.ContainsKey(playerId);
    }

    public static void clear(byte playerId)
    {
        remainingShotsMap.Remove(playerId);
    }

    public static int remainingShots(byte playerId, bool shoot = false)
    {
        if (!remainingShotsMap.TryGetValue(playerId, out int shots)) shots = 2;
        if (shoot) remainingShotsMap[playerId] = UnityEngine.Mathf.Max(0, shots - 1);
        return shots;
    }
}
