using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class LawyerGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        var lawyer = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is LawyerRole);

        if (lawyer == null || lawyer.Data.IsDead || lawyer.Data.Disconnected) return false;

        var target = LawyerRole.Target;
        if (target == null) return false;

        if (!target.Data.IsDead && !target.Data.Disconnected)
        {
            winners = new[] { lawyer.Data, target.Data };
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
        var lawyer = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is LawyerRole);

        if (lawyer == null) return;

        var color = new Color32(255, 152, 37, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Lawyer Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
