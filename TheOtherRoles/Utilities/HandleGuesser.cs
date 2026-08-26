using System;
using System.Collections.Generic;
using UnityEngine;
using TheOtherRoles.GameModes;

namespace TheOtherRoles.Utilities;

public static class HandleGuesser
{
    private static Sprite targetSprite;
    public static bool isGuesserGm = false;
    public static bool hasMultipleShotsPerMeeting = false;
    public static bool killsThroughShield = true;
    public static bool evilGuesserCanGuessSpy = true;
    public static bool guesserCantGuessSnitch = false;
    public static int tasksToUnlock = 0;

    // Stub fields for Guesser state - TODO: integrate with actual Guesser role classes
    public static PlayerControl niceGuesser;
    public static PlayerControl evilGuesser;
    public static int remainingShotsEvilGuesser = 2;
    public static int remainingShotsNiceGuesser = 2;

    public static Sprite getTargetSprite()
    {
        if (targetSprite) return targetSprite;
        targetSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.TargetIcon.png", 150f);
        return targetSprite;
    }

    public static bool isGuesser(byte playerId)
    {
        if (isGuesserGm) return GuesserGM.isGuesser(playerId);
        return isGuesserInternal(playerId);
    }

    public static void clear(byte playerId)
    {
        if (isGuesserGm) GuesserGM.clear(playerId);
        else clearInternal(playerId);
    }

    public static int remainingShots(byte playerId, bool shoot = false)
    {
        if (isGuesserGm) return GuesserGM.remainingShots(playerId, shoot);
        return remainingShotsInternal(playerId, shoot);
    }

    private static bool isGuesserInternal(byte playerId)
    {
        return (niceGuesser != null && niceGuesser.PlayerId == playerId) ||
               (evilGuesser != null && evilGuesser.PlayerId == playerId);
    }

    private static void clearInternal(byte playerId)
    {
        if (niceGuesser != null && niceGuesser.PlayerId == playerId) niceGuesser = null;
        else if (evilGuesser != null && evilGuesser.PlayerId == playerId) evilGuesser = null;
    }

    private static int remainingShotsInternal(byte playerId, bool shoot)
    {
        int remaining = remainingShotsEvilGuesser;
        if (niceGuesser != null && niceGuesser.PlayerId == playerId)
        {
            remaining = remainingShotsNiceGuesser;
            if (shoot) remainingShotsNiceGuesser = Mathf.Max(0, remainingShotsNiceGuesser - 1);
        }
        else if (shoot)
        {
            remainingShotsEvilGuesser = Mathf.Max(0, remainingShotsEvilGuesser - 1);
        }
        return remaining;
    }

    public static void clearAndReload()
    {
        clearInternal(niceGuesser != null ? niceGuesser.PlayerId : byte.MaxValue);
        clearInternal(evilGuesser != null ? evilGuesser.PlayerId : byte.MaxValue);
        niceGuesser = null;
        evilGuesser = null;
        remainingShotsEvilGuesser = 2;
        remainingShotsNiceGuesser = 2;
        isGuesserGm = TORMapOptions.gameMode == (int)CustomGameModes.Guesser;
    }
}
