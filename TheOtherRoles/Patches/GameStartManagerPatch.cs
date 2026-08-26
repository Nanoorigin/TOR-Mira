using HarmonyLib;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Update))]
public static class GameStartManagerUpdatePatch
{
    public static void Postfix(GameStartManager __instance)
    {
        // TODO: implement version handshake check
        // TODO: display version mismatch warning
    }
}

[HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Start))]
public static class GameStartManagerStartPatch
{
    public static void Postfix(GameStartManager __instance)
    {
        // TODO: initialize game start state
    }
}
