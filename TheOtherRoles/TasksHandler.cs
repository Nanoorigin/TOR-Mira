using HarmonyLib;

namespace TheOtherRoles;

[HarmonyPatch]
public static class TasksHandler
{
    public static Tuple<int, int> taskInfo(NetworkedPlayerInfo playerInfo)
    {
        int TotalTasks = 0;
        int CompletedTasks = 0;
        if (playerInfo != null && !playerInfo.Disconnected && playerInfo.Tasks != null &&
            playerInfo.Object &&
            playerInfo.Role && playerInfo.Role.TasksCountTowardProgress &&
            !playerInfo.Role.IsImpostor
            )
        {
            foreach (var playerInfoTask in playerInfo.Tasks.GetFastEnumerator())
            {
                if (playerInfoTask.Complete) CompletedTasks++;
                TotalTasks++;
            }
        }
        return Tuple.Create(CompletedTasks, TotalTasks);
    }

    [HarmonyPatch(typeof(GameData), nameof(GameData.RecomputeTaskCounts))]
    private static class GameDataRecomputeTaskCountsPatch
    {
        private static bool Prefix(GameData __instance)
        {
            var totalTasks = 0;
            var completedTasks = 0;

            foreach (var playerInfo in GameData.Instance.AllPlayers.GetFastEnumerator())
            {
                // TODO: Re-add role-specific task counting logic (Lover, Lawyer, Pursuer, Thief) when those roles are fully ported
                if (playerInfo.Object
                   )
                    continue;
                var (playerCompleted, playerTotal) = taskInfo(playerInfo);
                totalTasks += playerTotal;
                completedTasks += playerCompleted;
            }

            __instance.TotalTasks = totalTasks;
            __instance.CompletedTasks = completedTasks;
            return false;
        }
    }
}
