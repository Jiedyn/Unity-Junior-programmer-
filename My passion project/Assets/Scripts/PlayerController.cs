using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalinput;
    public float speed = 10f;
    public float yRange = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        else if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        
    }
}
