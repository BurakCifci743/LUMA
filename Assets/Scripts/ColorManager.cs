using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public ColorType currentColor=ColorType.None;

    public void SetColor(ColorType newColor)
    {
        currentColor = newColor;
        Debug.Log("Selected Color: " + currentColor);
    }
    
}
public enum ColorType
{
    None,
    Orange,
    Silver,
    Green
}
