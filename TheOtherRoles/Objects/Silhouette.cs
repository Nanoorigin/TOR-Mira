using UnityEngine;

namespace TheOtherRoles;

public class Silhouette
{
    private static Sprite sprite;
    public static List<Silhouette> silhouettes = new();
    public GameObject gameObject;
    public float age;

    public static void clearSilhouettes()
    {
        foreach (var sil in silhouettes)
            if (sil.gameObject) UnityEngine.Object.Destroy(sil.gameObject);
        silhouettes.Clear();
    }

    public Silhouette(Vector3 position, Color color)
    {
        gameObject = new GameObject("Silhouette");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.color = color;
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        silhouettes.Add(this);
    }

    public void Update()
    {
        age += Time.deltaTime;
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Silhouette.png", 500f);
        return sprite;
    }
}
