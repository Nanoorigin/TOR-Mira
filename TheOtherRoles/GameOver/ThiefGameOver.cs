using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class ThiefGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        var thief = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is ThiefRole);

        if (thief == null || thief.Data.IsDead || thief.Data.Disconnected) return false;

        // TODO: Implement HasStolen flag on ThiefRole
        if (false)
        {
            winners = new[] { thief.Data };
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
        var thief = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is ThiefRole);

        if (thief == null) return;

        var color = new Color32(142, 68, 173, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Thief Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
