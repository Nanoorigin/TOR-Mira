using HarmonyLib;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FixedUpdate))]
public static class PlayerControlFixedUpdatePatch
{
    public static void Postfix(PlayerControl __instance)
    {
        try
        {
            if (__instance == null || !__instance.AmOwner) return;
            var lp = PlayerControl.LocalPlayer;
            if (lp == null || lp.Data == null || lp.Data.IsDead) return;

            // TODO: implement targeting and role-specific update logic
        }
        catch
        {
            // Prevent NullRef crashes in per-frame patches
        }
    }
}
