using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverCanvas.SetActive(true);
             Time.timeScale = 0f;
        }
    }
}
