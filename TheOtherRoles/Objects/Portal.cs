using UnityEngine;

namespace TheOtherRoles;

public class Portal
{
    private static Sprite sprite;
    public static List<Portal> portals = new();
    public GameObject gameObject;
    public bool isExit;

    public static void clearPortals()
    {
        foreach (var portal in portals)
            if (portal.gameObject) UnityEngine.Object.Destroy(portal.gameObject);
        portals.Clear();
    }

    public Portal(Vector3 position, bool isExit)
    {
        this.isExit = isExit;
        gameObject = new GameObject("Portal");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        portals.Add(this);
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Portal.png", 500f);
        return sprite;
    }
}
