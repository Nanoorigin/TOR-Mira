using UnityEngine;

namespace TheOtherRoles;

public class JackInTheBox
{
    private static Sprite sprite;
    public static List<JackInTheBox> jackInTheBoxes = new();
    public GameObject gameObject;

    public static void clearJackInTheBoxes()
    {
        foreach (var box in jackInTheBoxes)
            if (box.gameObject) UnityEngine.Object.Destroy(box.gameObject);
        jackInTheBoxes.Clear();
    }

    public JackInTheBox(Vector3 position)
    {
        gameObject = new GameObject("JackInTheBox");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        jackInTheBoxes.Add(this);
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.JackInTheBox.png", 500f);
        return sprite;
    }
}
