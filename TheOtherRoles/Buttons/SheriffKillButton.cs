using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class SheriffKillButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Shoot";
    public override float Cooldown => OptionGroupSingleton<SheriffOptions>.Instance.Cooldown;
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

        var role = Target.GetModdedRole();
        if (role != null && role.Team == ModdedRoleTeams.Impostor ||
            (OptionGroupSingleton<SheriffOptions>.Instance.CanKillNeutrals && role?.Team == ModdedRoleTeams.Custom))
        {
            // TODO: implement via MiraAPI CustomMurderRpc
            Target.RpcMurderPlayer(Target, true);
        }
        else
        {
            // TODO: implement via MiraAPI CustomMurderRpc
            PlayerControl.LocalPlayer.RpcMurderPlayer(PlayerControl.LocalPlayer, true);
        }
    }

    public override bool Enabled(RoleBehaviour? role) => role is SheriffRole;
}
