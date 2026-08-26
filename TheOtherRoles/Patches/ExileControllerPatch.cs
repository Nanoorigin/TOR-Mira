using HarmonyLib;
using System.Linq;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(ExileController), nameof(ExileController.WrapUp))]
public static class ExileControllerWrapUpPatch
{
    public static void Postfix(ExileController __instance)
    {
        // TODO: implement exile logic when ExileController API is available
    }
}
