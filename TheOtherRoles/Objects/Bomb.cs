using UnityEngine;

namespace TheOtherRoles;

public class Bomb
{
    private static Sprite sprite;
    public static Bomb currentBomb;
    public GameObject gameObject;
    public float age;

    public static void clearBomb()
    {
        if (currentBomb?.gameObject)
            UnityEngine.Object.Destroy(currentBomb.gameObject);
        currentBomb = null;
    }

    public Bomb(Vector3 position)
    {
        clearBomb();
        gameObject = new GameObject("Bomb");
        gameObject.layer = 11;
        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = getSprite();
        renderer.material = new Material(Shader.Find("Sprites/Default"));
        gameObject.transform.position = position;
        currentBomb = this;
    }

    public void Update()
    {
        age += Time.deltaTime;
    }

    private static Sprite getSprite()
    {
        if (sprite) return sprite;
        sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Bomb.png", 500f);
        return sprite;
    }
}
