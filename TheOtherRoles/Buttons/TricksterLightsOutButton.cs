using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class TricksterLightsOutButton : CustomActionButton
{
    public override string Name => "Lights Out";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.LightsOutButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is TricksterRole;

    protected override void OnClick()
    {
        // TODO: implement Trickster toggle lights ability
    }
}
