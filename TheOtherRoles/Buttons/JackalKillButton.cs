using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Neutral;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class JackalKillButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Kill";
    public override float Cooldown => OptionGroupSingleton<JackalOptions>.Instance.KillCooldown;
    public override LoadableAsset<Sprite> Sprite => new RuntimeSpriteAsset();

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
        if (Target == null) return;

        // TODO: implement via MiraAPI CustomMurderRpc
        Target.RpcMurderPlayer(Target, true);
    }

    public override bool Enabled(RoleBehaviour? role) => role is JackalRole;
}
