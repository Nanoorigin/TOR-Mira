using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class TimeMasterRewindButton : CustomActionButton
{
    public override string Name => "Rewind";
    public override float Cooldown => OptionGroupSingleton<TimeMasterOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.RewindButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is TimeMasterRole;

    protected override void OnClick()
    {
        TimeMasterRole.timeShieldActive = true;
        // TODO: implement Time Master rewind ability (IsRewinding field needed)
    }
}
