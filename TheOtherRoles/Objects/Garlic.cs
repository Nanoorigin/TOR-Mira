using UnityEngine;

namespace TheOtherRoles;

public class Garlic
{
    private static Sprite sprite;
    public static List<GameObject> garlics = new();

    public Garlic(Vector3 position)
    {
        var garlicObject = new GameObject("Garlic");
        garlicObject.layer = 11;
        var renderer = garlicObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        garlicObject.transform.position = position;
        garlics.Add(garlicObject);
    }

    public static void clearGarlics()
    {
        foreach (var go in garlics)
            if (go) UnityEngine.Object.Destroy(go);
        garlics.Clear();
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Garlic.png", 500f);
        return sprite;
    }
}
