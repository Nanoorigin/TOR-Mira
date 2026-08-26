using HarmonyLib;
using TheOtherRoles.Roles.Crewmate;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.FixedUpdate))]
public static class PlayerPhysicsFixedUpdatePatch
{
    public static void Postfix(PlayerPhysics __instance)
    {
        if (!__instance.AmOwner) return;

        var localPlayer = PlayerControl.LocalPlayer;
        if (localPlayer == null || localPlayer.Data.IsDead) return;

        // TODO: implement AntiTeleport modifier logic
        // TODO: implement Lighter flashlight width logic
    }
}
