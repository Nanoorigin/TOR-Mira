using HarmonyLib;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetName))]
public static class PlayerControlSetNamePatch
{
    public static void Postfix(PlayerControl __instance, [HarmonyArgument(0)] string name)
    {
        // TODO: apply name color based on role (Snitch, Spy, etc.)
        // TODO: apply name tags for special roles
    }
}
