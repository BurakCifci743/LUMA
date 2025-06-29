using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public Transform target; 
    public float parallaxMultiplier = 0.1f;

    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        float deltaX = target.position.x * parallaxMultiplier;
        transform.position = new Vector3(startX + deltaX, transform.position.y, transform.position.z);
    }
}
