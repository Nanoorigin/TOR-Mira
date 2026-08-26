using MiraAPI.GameModes;

namespace TheOtherRoles.GameModes;

public class PropHuntGM : CustomGameMode
{
    public override string Name => "Prop Hunt";
    public override string Description => "Prop hunt mode";
    public override int Id => 3;

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
