using HarmonyLib;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(MapBehaviour), nameof(MapBehaviour.ShowNormalMap))]
public static class MapBehaviourShowNormalMapPatch
{
    public static void Postfix(MapBehaviour __instance)
    {
        // TODO: show vent/portals on map
    }
}
