using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class EngineerRepairButton : CustomActionButton
{
    public override string Name => "Repair";
    public override float Cooldown => 0f;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.RepairButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is EngineerRole;

    protected override void OnClick()
    {
        // TODO: Implement sabotage repair via MiraAPI
    }
}
