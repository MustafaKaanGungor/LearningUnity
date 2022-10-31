using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomChanger : MonoBehaviour
{
    public Vector2 camChangeX;
    public Vector2 camChangeY;
    public Vector3 playerChange;

    private SmoothCam cam;
    void Start()
    {
        cam = Camera.main.GetComponent<SmoothCam>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            cam.maxPos.x += camChangeX.x;
            cam.maxPos.y += camChangeY.x;
            cam.minPos.x += camChangeX.y;
            cam.minPos.y += camChangeY.y;

            other.transform.position += playerChange;
        }
    }
}
