using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Crewmate;
using TheOtherRoles.Roles.Crewmate;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class TrapperTrapButton : CustomActionButton
{
    public override string Name => "Trap";
    public override float Cooldown => OptionGroupSingleton<TrapperOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.Trapper_Place_Button.png");

    public override bool Enabled(RoleBehaviour? role) => role is TrapperRole;

    protected override void OnClick()
    {
        TrapperRole.trapDuration = OptionGroupSingleton<TrapperOptions>.Instance.TrapDuration;
    }
}
