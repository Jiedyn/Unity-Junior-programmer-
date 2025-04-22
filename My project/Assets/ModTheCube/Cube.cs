using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        transform.position = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        transform.localScale = Vector3.one * 3f;
        Invoke("ChangeColour", 3);
    }

    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    public void ChangeColour()
    {
        Material material = Renderer.material;

        gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        Debug.Log("colour");
    }
}
