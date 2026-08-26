using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class ArsonistGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        // TODO: Implement ignite trigger flag on ArsonistRole

        var arsonist = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is ArsonistRole);

        if (arsonist == null || arsonist.Data.IsDead || arsonist.Data.Disconnected) return false;

        var allAlivePlayers = PlayerControl.AllPlayerControls.ToArray()
            .Where(p => !p.Data.Disconnected && !p.Data.IsDead && p != arsonist)
            .ToList();

        if (allAlivePlayers.Count == 0) return false;

        var allDoused = allAlivePlayers.All(p => ArsonistRole.DousedPlayers.Contains(p));

        if (allDoused)
        {
            winners = new[] { arsonist.Data };
            return true;
        }

        return false;
    }

    public override bool BeforeEndGameSetup(EndGameManager endGameManager)
    {
        return true;
    }

    public override void AfterEndGameSetup(EndGameManager endGameManager)
    {
        var arsonist = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is ArsonistRole);

        if (arsonist == null) return;

        var color = new Color32(255, 200, 0, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Arsonist Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version; use WinText subtitle
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
