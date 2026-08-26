using HarmonyLib;
using TheOtherRoles.Roles.Crewmate;
using TheOtherRoles.Roles.Impostor;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.CheckForEndVoting))]
public static class MeetingHudCheckForEndVotingPatch
{
    public static bool Prefix(MeetingHud __instance)
    {
        // TODO: implement full vote counting logic with Swapper swap, Mayor double vote, etc.
        // For now, allow vanilla behavior
        return true;
    }

    public static void Postfix(MeetingHud __instance)
    {
        if (!AmongUsClient.Instance.AmHost) return;

        // Count votes with role modifications
        // TODO: implement Swapper vote swapping
        // TODO: implement Mayor double vote
        // TODO: implement VoteCollector vote tracking
    }
}

[HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.VotingComplete))]
public static class MeetingHudVotingCompletePatch
{
    public static void Postfix(MeetingHud __instance)
    {
        // TODO: implement Lawyer/Sidekick promotion logic after vote
        // TODO: implement Witch spell triggers
        // TODO: implement Eraser role erasing after vote
    }
}

[HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.ServerStart))]
public static class MeetingHudServerStartPatch
{
    public static void Postfix(MeetingHud __instance)
    {
        // TODO: populate button states for Mayor, Swapper, etc.
    }
}

[HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Update))]
public static class MeetingHudUpdatePatch
{
    public static void Postfix(MeetingHud __instance)
    {
        // TODO: implement vote color display for Mayor
        // TODO: implement Guesser UI shooting buttons
        // TODO: implement Prosecutor button
    }
}

[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.StartMeeting))]
public static class PlayerControlStartMeetingPatch
{
    public static void Prefix(PlayerControl __instance, NetworkedPlayerInfo target)
    {
        // TODO: implement Witch spell casting on meeting start
        // TODO: implement future erase logic
        // TODO: implement future shield logic
    }

    public static void Postfix(PlayerControl __instance, NetworkedPlayerInfo target)
    {
        // TODO: implement post-meeting-start logic
    }
}
