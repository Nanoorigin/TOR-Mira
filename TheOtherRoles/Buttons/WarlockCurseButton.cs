using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class WarlockCurseButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Curse";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.CurseButton.png");

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
        // TODO: implement Warlock curse ability
    }

    public override bool Enabled(RoleBehaviour? role) => role is WarlockRole;
}
