using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRoles;

public static class TrackerState
{
    public static float UpdateIntervall;
    public static bool ResetTargetAfterMeeting;
    public static bool CanTrackCorpses;
    public static float CorpsesTrackingCooldown;
    public static float CorpsesTrackingDuration;
    public static float CorpsesTrackingTimer;
    public static int TrackingMode;
    public static PlayerControl CurrentTarget;
    public static List<Arrow> Tracked = new();
    public static bool UsedTracker;
}

public enum TrackingMode
{
    PlayersAndCorpses,
    PlayersOnly,
    CorpsesOnly
}
