using UnityEngine;

public class ColorPlatform : MonoBehaviour
{
    public ColorManager colorManager;
    public ColorType platformColor;

    private SpriteRenderer sr;
    private Collider2D col;

    void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        col = GetComponent<Collider2D>();

        if (colorManager == null)
        {
            colorManager = FindFirstObjectByType<ColorManager>();
            if (colorManager != null)
                Debug.Log($"ColorManager found at runtime by {gameObject.name}");
            else
                Debug.LogWarning($"ColorManager not found by {gameObject.name}");
        }
    }

    void Update()
    {
        if (colorManager == null) return;

        bool isActive = colorManager.currentColor == platformColor;

        sr.enabled = isActive;
        col.enabled = isActive;
    }
}
