using HarmonyLib;
using TheOtherRoles.Roles.Crewmate;
using TheOtherRoles.Roles.Impostor;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(IntroCutscene), nameof(IntroCutscene.OnDestroy))]
public static class IntroCutsceneOnDestroyPatch
{
    public static void Postfix(IntroCutscene __instance)
    {
        // TODO: generate player icons for Tracker arrows, Snitch arrows, etc.
    }
}

[HarmonyPatch(typeof(IntroCutscene), nameof(IntroCutscene.ShowRole))]
public static class IntroCutsceneShowRolePatch
{
    public static void Postfix(IntroCutscene __instance)
    {
        // TODO: customize role reveal text for modded roles
        var localPlayer = PlayerControl.LocalPlayer;
        if (localPlayer == null) return;

        var role = localPlayer.GetModdedRole();
        if (role == null) return;

        // TODO: set custom role description text
    }
}

[HarmonyPatch(typeof(IntroCutscene), nameof(IntroCutscene.BeginCrewmate))]
public static class IntroCutsceneBeginCrewmatePatch
{
    public static void Postfix(IntroCutscene __instance, ref Il2CppSystem.Collections.Generic.List<PlayerControl> teamToDisplay)
    {
        // TODO: populate team list for modded crew roles
    }
}

[HarmonyPatch(typeof(IntroCutscene), nameof(IntroCutscene.BeginImpostor))]
public static class IntroCutsceneBeginImpostorPatch
{
    public static void Postfix(IntroCutscene __instance, ref Il2CppSystem.Collections.Generic.List<PlayerControl> yourTeam)
    {
        // TODO: populate team list for modded impostor roles
    }
}
