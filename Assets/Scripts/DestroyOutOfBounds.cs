using UnityEngine;

public class DestroyOutOfBouds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        } else if (transform.position.z < -10)
        {
            Debug.Log("Game Over!");
            // track your script self note
            Destroy(gameObject);
        }
    }
} // "gameObject" means what the script is paired to
