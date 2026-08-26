using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class SeerRevealButton : CustomActionButton
{
    public override string Name => "Reveal";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.SeerButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is SeerRole;

    protected override void OnClick()
    {
        // TODO: implement Seer reveal soul positions (DeadBodyPositions field needed)
    }
}
