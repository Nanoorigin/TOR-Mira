using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class SnitchRevealButton : CustomActionButton
{
    public override string Name => "Reveal";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.Reveal.png");

    public override bool Enabled(RoleBehaviour? role) => role is SnitchRole;

    protected override void OnClick()
    {
        // TODO: implement Snitch reveal ability
    }
}
