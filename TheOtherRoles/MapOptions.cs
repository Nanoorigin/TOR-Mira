using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TheOtherRoles;

public static class TORMapOptions
{
    public static int gameMode = 0;

    public static bool allowParallelMedbayScans = false;
    public static bool showGraveyard = false;
    public static bool taskPanelClassic = false;

    public static float discussionsTime = 120f;
    public static float votingTime = 120f;
    public static float playerSpeed = 1.25f;
    public static float killCooldown = 30f;
    public static int killDistance = 1;
    public static int taskBarUpdate = 0;
    public static bool visualTasks = true;
    public static bool confirmImpostor = true;
    public static int emergencyCooldown = 30;
    public static int emergencyCount = 1;
    public static int maxPlayers = 15;
    public static int DiscussionTime = 120;
    public static int VotingTime = 120;
    public static bool skipVote = true;
    public static bool noVoteIsDead = false;
    public static bool anonymousVotes = false;
    public static bool confirmEjects = true;
    public static int ejectPercentage = 0;

    public static bool isHideAndSeek = false;
    public static bool allowVentingForCrewmates = false;
    public static bool killCrewmatesBeforeEmergency = false;
    public static bool validKillTarget = false;

    public static bool mapHack = false;
    public static bool miniCrewmate = false;
    public static bool disableMinigame = false;
    public static bool gangnamStyle = false;
    public static bool disableTaskYP = false;

    public static bool enableSoundEffects = true;

    public static void ClearAndReload()
    {
        gameMode = 0;
    }
}

public enum CustomGameModes
{
    Classic,
    Guesser,
    HideNSeek,
    PropHunt
}
