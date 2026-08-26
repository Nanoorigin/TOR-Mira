using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class TricksterPlaceJackInTheBoxButton : CustomActionButton
{
    public override string Name => "Place Jack-In-The-Box";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.PlaceJackInTheBoxButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is TricksterRole;

    protected override void OnClick()
    {
        // TODO: implement Trickster place Jack-In-The-Box ability
    }
}
