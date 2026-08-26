using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class CamouflagerCamoButton : CustomActionButton
{
    public override string Name => "Camouflage";
    public override float Cooldown => OptionGroupSingleton<CamouflagerOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.CamoButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is CamouflagerRole;

    protected override void OnClick()
    {
        CamouflagerRole.Timer = OptionGroupSingleton<CamouflagerOptions>.Instance.CamoDuration;
    }
}
