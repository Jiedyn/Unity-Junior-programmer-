using UnityEngine;

public class PropellerScript : MonoBehaviour
{

    private float rotationSpeed = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 20 * Time.deltaTime * rotationSpeed);

        // declaring the script as a variable so you can alter and reuse it in the future
        // Roblox Functions = Unity Variables
        // Vector3 myRotateVector = new Vector3(0, 0, 20 * Time.deltaTime * rotationSpeed);
        // transform.Rotate(myRotateVector);
    }
}
