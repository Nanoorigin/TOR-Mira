using MiraAPI.GameModes;

namespace TheOtherRoles.GameModes;

public class HideNSeekGM : CustomGameMode
{
    public override string Name => "Hide and Seek";
    public override string Description => "Hide and seek mode";
    public override int Id => 2;

    public override void CheckGameEnd(out bool runOriginal, LogicGameFlowNormal instance)
    {
        runOriginal = true;
    }

    public override void AssignRoles(out bool runOriginal, LogicRoleSelectionNormal instance)
    {
        runOriginal = true;
    }

    public override bool CanVent(Vent vent, NetworkedPlayerInfo playerInfo)
    {
        return false;
    }

    public override bool CanReport(DeadBody body)
    {
        return false;
    }

    public override bool AreRoleSettingsEnabled()
    {
        return false;
    }
}
