using UnityEngine;

namespace TheOtherRoles;

public class NinjaTrace
{
    private static Sprite sprite;
    public static List<NinjaTrace> traces = new();
    public GameObject gameObject;
    public float age;

    public static void clearTraces()
    {
        foreach (var trace in traces)
            if (trace.gameObject) UnityEngine.Object.Destroy(trace.gameObject);
        traces.Clear();
    }

    public NinjaTrace(Vector3 position)
    {
        gameObject = new GameObject("NinjaTrace");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        traces.Add(this);
    }

    public void Update()
    {
        age += Time.deltaTime;
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.NinjaTrace.png", 500f);
        return sprite;
    }
}
