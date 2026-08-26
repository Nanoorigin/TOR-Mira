using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class SwapperSwapButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Swap";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.SwapperCheck.png");

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
        if (SwapperRole.swapCharges <= 0) return;
        if (Target == null) return;

        if (SwapperRole.Swapper1 == null)
        {
            SwapperRole.Swapper1 = Target;
        }
        else
        {
            SwapperRole.Swapper2 = Target;
            SwapperRole.swapCharges--;
        }
    }

    public override bool Enabled(RoleBehaviour? role) => role is SwapperRole && SwapperRole.swapCharges > 0;
}
