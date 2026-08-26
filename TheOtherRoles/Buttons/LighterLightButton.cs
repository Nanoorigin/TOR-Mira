using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class LighterLightButton : CustomActionButton
{
    public override string Name => "Light";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.LighterButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is LighterRole;

    protected override void OnClick()
    {
        // TODO: implement Lighter flashlight ability
    }
}
