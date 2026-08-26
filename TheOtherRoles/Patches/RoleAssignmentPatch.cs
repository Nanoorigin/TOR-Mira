using HarmonyLib;
using TheOtherRoles.Roles.Crewmate;
using TheOtherRoles.Roles.Impostor;
using TheOtherRoles.Roles.Neutral;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(RoleManager), nameof(RoleManager.SelectRoles))]
public static class RoleManagerSelectRolesPatch
{
    public static void Postfix(RoleManager __instance)
    {
        // TODO: implement custom role assignment logic
        // Assign Sheriff, Tracker, Mayor, Jester, Jackal, etc.
    }
}
