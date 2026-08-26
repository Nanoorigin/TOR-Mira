using System.Collections.Generic;
using System.Linq;
using MiraAPI.GameEnd;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.GameOver;

public class JackalGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        var jackal = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is JackalRole);

        if (jackal == null || jackal.Data.IsDead || jackal.Data.Disconnected) return false;

        var sidekick = JackalRole.Sidekick;
        var hasSidekick = sidekick != null && !sidekick.Data.IsDead && !sidekick.Data.Disconnected;

        var alivePlayers = PlayerControl.AllPlayerControls.ToArray()
            .Where(p => !p.Data.Disconnected && !p.Data.IsDead)
            .ToList();

        var aliveJackalTeam = alivePlayers.Where(p =>
            p.GetModdedRole() is JackalRole ||
            (hasSidekick && p == sidekick))
            .ToList();

        if (aliveJackalTeam.Count == 0) return false;

        var nonJackalPlayers = alivePlayers.Where(p =>
            p.GetModdedRole() is not JackalRole &&
            !(hasSidekick && p == sidekick))
            .ToList();

        if (nonJackalPlayers.Count == 0)
        {
            var winnerList = new List<NetworkedPlayerInfo> { jackal.Data };
            if (hasSidekick) winnerList.Add(sidekick.Data);
            winners = winnerList.ToArray();
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
        var jackal = PlayerControl.AllPlayerControls.ToArray().FirstOrDefault(p =>
            p.GetModdedRole() is JackalRole);

        if (jackal == null) return;

        var color = new Color32(0, 191, 255, 255);
        endGameManager.BackgroundBar.material.color = color;
        endGameManager.WinText.text = "Jackal Wins";
        endGameManager.WinText.color = color;
        // TODO: EndGameManager.ImpostorText not available in this game version
        endGameManager.WinText.gameObject.SetActive(true);
    }
}
