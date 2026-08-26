using HarmonyLib;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
public static class PingTrackerUpdatePatch
{
    public static void Postfix(PingTracker __instance)
    {
        // TODO: add mod version display to ping tracker
        // __instance.text.text += $"\n<color=#1a1a2e>The Other Roles v{TheOtherRolesPlugin.VersionString}</color>";
    }
}

[HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
public static class VersionShowerStartPatch
{
    public static void Postfix(VersionShower __instance)
    {
        // TODO: display mod version on title screen
    }
}
