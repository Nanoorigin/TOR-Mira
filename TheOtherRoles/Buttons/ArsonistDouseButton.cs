using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Neutral;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class ArsonistDouseButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Douse";
    public override float Cooldown => OptionGroupSingleton<ArsonistOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.DouseButton.png");

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

        ArsonistRole.CurrentDouseTarget = Target;
        ArsonistRole.DouseDuration = OptionGroupSingleton<ArsonistOptions>.Instance.DouseDuration;
    }

    public override bool Enabled(RoleBehaviour? role) => role is ArsonistRole;
}
