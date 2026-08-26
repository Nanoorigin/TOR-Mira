using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class JesterGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        if (JesterRole.TriggerJesterWin)
        {
            var jester = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
                p.GetModdedRole() is JesterRole);

            if (jester != null)
            {
                winners = new[] { jester.Data };
                return true;
            }
        }

        return false;
    }

    public override bool BeforeEndGameSetup(EndGameManager endGameManager)
    {
        return true;
    }

    public override void AfterEndGameSetup(EndGameManager endGameManager)
    {
        var jester = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is JesterRole);

        if (jester == null) return;

        var color = new Color32(236, 98, 165, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Jester Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
