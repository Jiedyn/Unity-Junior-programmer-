using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // This script is used to find an Object in the game that you want to use in your script 
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -11);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    // by changing void Update() to void LateUpdate() the script will update after the initial update happens
    void LateUpdate()
    {
        // this script finds the camera position and sets it to the players position + Add to the cameras position
        // transform.position = player.transform.position + new Vector3(0, 7, -11);

        // by turning new Vector3(0, 7, -11) into a variable we can alter it in the script later and its not hard coded
        transform.position = player.transform.position + offset;
    }
}
