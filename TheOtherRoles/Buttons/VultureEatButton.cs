using System.Linq;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Neutral;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class VultureEatButton : CustomActionButton
{
    public override string Name => "Eat";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.VultureButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is VultureRole;

    protected override void OnClick()
    {
        // TODO: implement Vulture eat ability
    }
}
