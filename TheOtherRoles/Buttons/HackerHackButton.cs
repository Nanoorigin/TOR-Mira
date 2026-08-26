using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class HackerHackButton : CustomActionButton
{
    public override string Name => "Hack";
    public override float Cooldown => OptionGroupSingleton<HackerOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.HackerButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is HackerRole;

    protected override void OnClick()
    {
        // TODO: implement Hacker hack timer logic
    }
}
