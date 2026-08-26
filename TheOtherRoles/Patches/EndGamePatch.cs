using HarmonyLib;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.SetEverythingUp))]
public static class EndGameManagerSetEverythingUpPatch
{
    public static void Postfix(EndGameManager __instance)
    {
        // TODO: implement custom win condition display
    }
}
