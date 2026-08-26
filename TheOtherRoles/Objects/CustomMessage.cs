using UnityEngine;

namespace TheOtherRoles;

public class CustomMessage
{
    public static List<CustomMessage> messages = new();
    public GameObject gameObject;
    public float lifetime;
    public float age;

    public static void clearMessages()
    {
        foreach (var msg in messages)
            if (msg.gameObject) UnityEngine.Object.Destroy(msg.gameObject);
        messages.Clear();
    }

    public CustomMessage(string text, float lifetime, Vector3 position)
    {
        this.lifetime = lifetime;
        gameObject = new GameObject("CustomMessage");
        gameObject.transform.position = position;
        messages.Add(this);
    }

    public void Update()
    {
        age += Time.deltaTime;
    }

    public bool isExpired() => age >= lifetime;
}
