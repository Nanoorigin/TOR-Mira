using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TheOtherRoles.Buttons;

public sealed class RuntimeSpriteAsset : LoadableAsset<Sprite>
{
    public override Sprite LoadAsset()
    {
        if (LoadedAsset) return LoadedAsset;
        var btn = HudManager.Instance?.KillButton?.graphic;
        return btn != null ? LoadedAsset = btn.sprite : null;
    }
}
