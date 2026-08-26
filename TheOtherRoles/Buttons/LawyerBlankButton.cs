using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class LawyerBlankButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Blank";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.PursuerButton.png");

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
        // TODO: implement Lawyer blank ability
    }

    public override bool Enabled(RoleBehaviour? role) => role is LawyerRole;
}
