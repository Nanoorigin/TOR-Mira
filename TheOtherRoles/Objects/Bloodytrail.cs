using UnityEngine;

namespace TheOtherRoles;

public class Bloodytrail
{
    private static Dictionary<byte, GameObject> sprites = new();
    private static Sprite sprite;

    public static void resetSprites()
    {
        foreach (var go in sprites.Values)
            if (go) UnityEngine.Object.Destroy(go);
        sprites.Clear();
    }

    public Bloodytrail(PlayerControl player, PlayerControl bloodyPlayer)
    {
        if (player == null || sprite == null) return;
    }

    public static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Blood1.png", 500f);
        return sprite;
    }
}
