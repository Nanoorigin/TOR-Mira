using UnityEngine;

namespace TheOtherRoles;

public class Footprint
{
    private static Sprite sprite;
    public GameObject footprint;
    public float age;
    public PlayerControl owner;

    public static List<Footprint> allFootprints = new();

    public static void clearFootprints()
    {
        foreach (var fp in allFootprints)
            if (fp.footprint) UnityEngine.Object.Destroy(fp.footprint);
        allFootprints.Clear();
    }

    public Footprint(float footprintDuration, PlayerControl owner, bool anonymous)
    {
        this.owner = owner;
        footprint = new GameObject("Footprint");
        footprint.layer = 11;
        var renderer = footprint.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.color = anonymous ? new Color(0.8f, 0.8f, 0.8f, 0.6f) : Color.white;
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        footprint.transform.position = owner.transform.position;
        footprint.transform.Rotate(0, 0, UnityEngine.Random.Range(0, 360));
        allFootprints.Add(this);
    }

    public void Update()
    {
        age += Time.deltaTime;
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Footprint.png", 500f);
        return sprite;
    }
}
