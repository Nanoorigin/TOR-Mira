using HarmonyLib;
using MiraAPI.Roles;
using TheOtherRoles.Roles.Crewmate;
using TheOtherRoles.Roles.Impostor;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Patches;

[HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
public static class HudManagerUpdatePatch
{
    public static void Postfix(HudManager __instance)
    {
        if (PlayerControl.LocalPlayer == null || PlayerControl.LocalPlayer.Data.IsDead) return;

        var localPlayer = PlayerControl.LocalPlayer;
        var role = localPlayer.GetModdedRole();

        // Update name colors
        updateNameColors();

        // Update role-specific button visibility
        updateRoleButtons(__instance, role);

        // Update name tags
        updateNameTags();
    }

    private static void updateNameColors()
    {
        foreach (var player in PlayerControl.AllPlayerControls)
        {
            if (player == null || player.Data == null || player.Data.IsDead || player.Data.Disconnected) continue;

            var role = player.GetModdedRole();
            if (role == null) continue;

            // TODO: set name color based on role
            // Snitch sees impostors in red, Spy appears as impostor, etc.
        }
    }

    private static void updateRoleButtons(HudManager hud, ICustomRole role)
    {
        if (role == null) return;

        // TODO: show/hide buttons based on role
        // Sheriff kill button, Tracker track button, Vampire bite button, etc.

        bool isImpostor = role.Team == ModdedRoleTeams.Impostor;
        bool isCrewmate = role.Team == ModdedRoleTeams.Crewmate;

        // Update kill button visibility
        if (hud.KillButton != null)
        {
            bool canKill = isImpostor || role is SheriffRole || role is JackalRole;
            hud.KillButton.gameObject.SetActive(canKill);
        }
    }

    private static void updateNameTags()
    {
        foreach (var player in PlayerControl.AllPlayerControls)
        {
            if (player == null || player.Data == null || player.Data.IsDead || player.Data.Disconnected) continue;

            // TODO: display role name tags for Snitch, Medium seance target, etc.
        }
    }
}
