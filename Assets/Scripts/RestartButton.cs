using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void RestartGame()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
