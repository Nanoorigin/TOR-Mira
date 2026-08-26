using UnityEngine;

namespace TheOtherRoles;

public class Arrow
{
    public GameObject arrow;
    private SpriteRenderer renderer;

    public Arrow(Color color)
    {
        arrow = new GameObject("Arrow");
        arrow.transform.position = Vector3.zero;
        renderer = arrow.AddComponent<SpriteRenderer>();
        renderer.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Arrow.png", 500f);
        renderer.color = color;
        renderer.material = new Material(Shader.Find("UI/Default"));
        renderer.material.renderQueue = 5000;
        arrow.SetActive(false);
    }

    public void update(Vector3 position, bool active = true)
    {
        if (arrow == null) return;
        arrow.SetActive(active);
        if (!active) return;

        Vector3 targetPos = position - PlayerControl.LocalPlayer.transform.position;
        targetPos.z = 0;
        float angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        arrow.transform.position = PlayerControl.LocalPlayer.transform.position;
        arrow.transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
    }

    public void destroy()
    {
        if (arrow != null)
        {
            UnityEngine.Object.Destroy(arrow);
            arrow = null;
        }
    }
}
