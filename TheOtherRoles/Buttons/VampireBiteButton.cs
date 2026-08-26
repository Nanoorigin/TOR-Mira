using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class VampireBiteButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Bite";
    public override float Cooldown => OptionGroupSingleton<VampireOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.VampireButton.png");

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

        VampireRole.Bitten = Target;
        VampireRole.KillDelay = OptionGroupSingleton<VampireOptions>.Instance.KillDelay;
    }

    public override bool Enabled(RoleBehaviour? role) => role is VampireRole;
}
