using UnityEngine;

namespace TheOtherRoles;

public class Trap
{
    private static Sprite sprite;
    public static List<Trap> traps = new();
    public GameObject gameObject;
    public PlayerControl owner;
    public bool triggered;

    public static void clearTraps()
    {
        foreach (var trap in traps)
            if (trap.gameObject) UnityEngine.Object.Destroy(trap.gameObject);
        traps.Clear();
    }

    public Trap(Vector3 position, PlayerControl owner)
    {
        this.owner = owner;
        gameObject = new GameObject("Trap");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        traps.Add(this);
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Trap.png", 500f);
        return sprite;
    }
}
