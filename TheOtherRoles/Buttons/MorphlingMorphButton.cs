using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class MorphlingMorphButton : CustomActionButton
{
    public override string Name => "Morph";
    public override float Cooldown => OptionGroupSingleton<MorphlingOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.MorphButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is MorphlingRole;

    protected override void OnClick()
    {
        if (MorphlingRole.SampledTarget == null) return;

        MorphlingRole.MorphTarget = MorphlingRole.SampledTarget;
        MorphlingRole.Timer = OptionGroupSingleton<MorphlingOptions>.Instance.MorphDuration;
    }
}
