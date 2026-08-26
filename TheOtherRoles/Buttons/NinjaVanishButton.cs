using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class NinjaVanishButton : CustomActionButton
{
    public override string Name => "Vanish";
    public override float Cooldown => OptionGroupSingleton<NinjaOptions>.Instance.MarkCooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.NinjaAssassinateButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is NinjaRole;

    protected override void OnClick()
    {
        // TODO: implement Ninja vanish ability (InvisibleTimer/IsInvisible fields needed)
    }
}
