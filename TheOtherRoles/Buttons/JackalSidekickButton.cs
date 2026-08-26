using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Neutral;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class JackalSidekickButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Sidekick";
    public override float Cooldown => OptionGroupSingleton<JackalOptions>.Instance.SidekickCooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.SidekickButton.png");

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

        JackalRole.Sidekick = Target;
    }

    public override bool Enabled(RoleBehaviour? role) => role is JackalRole;
}
