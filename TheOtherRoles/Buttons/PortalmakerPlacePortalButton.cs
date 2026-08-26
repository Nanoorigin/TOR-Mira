using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class PortalmakerPlacePortalButton : CustomActionButton
{
    public override string Name => "Place Portal";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.PlacePortalButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is PortalmakerRole;

    protected override void OnClick()
    {
        // TODO: implement Portalmaker place portal ability
    }
}
