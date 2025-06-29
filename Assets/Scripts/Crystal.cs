using UnityEngine;

public class Crystal : MonoBehaviour
{
    public ColorManager colorManager;        
    public ColorType crystalColor;           

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            colorManager.SetColor(crystalColor);
        }
    }
}
