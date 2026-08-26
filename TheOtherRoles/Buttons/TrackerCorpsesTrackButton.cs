using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class TrackerCorpsesTrackButton : CustomActionButton
{
    public override string Name => "Track Corpses";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.PathfindButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is TrackerRole;

    protected override void OnClick()
    {
        // TODO: implement Tracker corpse tracking ability
    }
}
