using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class WarlockCleanseButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Cleanse";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.CurseKillButton.png");

    public override PlayerControl? GetTarget()
    {
        return PlayerControl.LocalPlayer.GetClosestPlayer();
    }

    public override void SetOutline(bool active)
    {
    }

    public override bool IsTargetValid(PlayerControl? target)
    {
        return base.IsTargetValid(target) && !target!.Data.Disconnected && !target.Data.IsDead;
    }

    protected override void OnClick()
    {
        // TODO: implement Warlock cleanse ability
    }

    public override bool Enabled(RoleBehaviour? role) => role is WarlockRole;
}
