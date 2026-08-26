using System.Linq;
using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using TheOtherRoles.Options.Roles.Impostor;
using TheOtherRoles.Roles.Impostor;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class JanitorCleanButton : CustomActionButton
{
    public override string Name => "Clean";
    public override float Cooldown => OptionGroupSingleton<JanitorOptions>.Instance.Cooldown;
    public override LoadableAsset<Sprite> Sprite => new LoadableResourceAsset("TheOtherRoles.Resources.CleanButton.png");

    public override bool Enabled(RoleBehaviour? role) => role is JanitorRole;

    protected override void OnClick()
    {
        var body = UnityEngine.Object.FindObjectsOfType<DeadBody>()
            .OrderBy(b => Vector2.Distance(PlayerControl.LocalPlayer.transform.position, b.transform.position))
            .FirstOrDefault();

        if (body != null)
        {
            UnityEngine.Object.Destroy(body.gameObject);
        }
    }
}
