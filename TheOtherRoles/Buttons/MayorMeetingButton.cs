using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class MayorMeetingButton : CustomActionButton
{
    public override string Name => "Emergency";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.EmergencyButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is MayorRole && MayorRole.NumberOfRemoteMeetings > 0;

    protected override void OnClick()
    {
        if (MayorRole.NumberOfRemoteMeetings <= 0) return;

        PlayerControl.LocalPlayer.CmdReportDeadBody(null);
        MayorRole.NumberOfRemoteMeetings--;
    }
}
