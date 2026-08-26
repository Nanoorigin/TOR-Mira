using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class VultureGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        var vulture = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is VultureRole);

        if (vulture == null || vulture.Data.IsDead || vulture.Data.Disconnected) return false;

        if (VultureRole.EatenCorpseCount >= VultureRole.CorpsesNeeded)
        {
            winners = new[] { vulture.Data };
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
        var vulture = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is VultureRole);

        if (vulture == null) return;

        var color = new Color32(156, 113, 58, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Vulture Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
