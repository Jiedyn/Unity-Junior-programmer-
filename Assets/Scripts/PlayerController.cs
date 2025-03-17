using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // by making this a  public float, you can change it in unity
    private float speed = 25;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Move's the vehicle forward
        // transform.Translate(0, 0, 1);
        // alternate way of saying vehicle forward using familiar words
        // transform.Translate(Vector3.forward);
        // using * Time.deltaTime (* means times because x is considered a letter) Time.deltaTime uses time elapsed between each frame to do Vector3.forward
        // time means original time and deltaTime means the change in time 
        // * 20 just means its timesing the positions by 20 (0*20,0*20, 1*20)
        // transform.Translate(Vector3.forward * Time.deltaTime * 20);
        // by turning 20 into speed its not hardset anymore and can be editted in the future

        // player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turns the Vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
