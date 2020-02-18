using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    //Run before the game start
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //Update per frame
    void Update()
    {
        Follow();
    }

    //A follow funtion that keep trake with the camera's position
    void Follow()
    {
        Vector3 camera = transform.position;

        if (target.position.x > 9.6f)
        { camera.x = 9.6f; }
        else if (target.position.x < -9.6)
        { camera.x = -9.6f; }
        else 
        { camera.x = target.position.x; }

        if (target.position.y > 5.4f)
        { camera.y = 5.4f; }
        else if (target.position.y < -5.4f)
        { camera.y = -5.4f; }
        else
        { camera.y = target.position.y; }

        transform.position = camera;
    }
}
