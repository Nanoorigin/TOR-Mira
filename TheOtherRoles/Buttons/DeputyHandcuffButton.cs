using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class DeputyHandcuffButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Handcuff";
    public override float Cooldown => OptionGroupSingleton<DeputyOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.DeputyHandcuffButton.png");

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

        DeputyRole.Handcuffed = Target;
    }

    public override bool Enabled(RoleBehaviour? role) => role is DeputyRole;
}
