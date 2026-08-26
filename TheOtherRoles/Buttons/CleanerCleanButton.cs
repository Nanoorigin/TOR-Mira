using System.Linq;
using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class CleanerCleanButton : CustomActionButton<PlayerControl>
{
    public override string Name => "Clean";
    public override float Cooldown => OptionGroupSingleton<CleanerOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.CleanButton.png");

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
        var body = UnityEngine.Object.FindObjectsOfType<DeadBody>()
            .OrderBy(b => Vector2.Distance(PlayerControl.LocalPlayer.transform.position, b.transform.position))
            .FirstOrDefault();

        if (body != null)
        {
            UnityEngine.Object.Destroy(body.gameObject);
        }
    }

    public override bool Enabled(RoleBehaviour? role) => role is CleanerRole;
}
