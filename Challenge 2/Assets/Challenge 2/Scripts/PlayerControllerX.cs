using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool canSpawnDog;
    private void Start()
    {
        canSpawnDog = true;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawnDog = false;

            Invoke("ResetSpawnDog", 2f);
            // time.deltaTime script to delay next imput and spam
        }
    }
    private void ResetSpawnDog()
    {
        canSpawnDog = true;
    }
}
