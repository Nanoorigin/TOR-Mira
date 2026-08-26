using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class SecurityGuardPlaceCameraButton : CustomActionButton
{
    public override string Name => "Place Camera";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.PlaceCameraButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is SecurityGuardRole;

    protected override void OnClick()
    {
        // TODO: implement SecurityGuard place camera ability
    }
}
