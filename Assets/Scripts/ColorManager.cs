using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public ColorType currentColor;

    public void SetColor(ColorType newColor)
    {
        currentColor = newColor;
        Debug.Log("Selected Color: " + currentColor);
    }
}
public enum ColorType
{
    Orange,
    Silver,
    Green
}
