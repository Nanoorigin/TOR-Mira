using HarmonyLib;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(ShipStatus), nameof(ShipStatus.Start))]
public static class ShipStatusStartPatch
{
    public static void Postfix(ShipStatus __instance)
    {
        // TODO: cache ShipStatus instance
    }
}
