using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Neutral;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class ArsonistIgniteButton : CustomActionButton
{
    public override string Name => "Ignite";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.IgniteButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is ArsonistRole;

    protected override void OnClick()
    {
        // TODO: implement Arsonist ignite win condition
    }
}
