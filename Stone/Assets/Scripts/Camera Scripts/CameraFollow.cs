using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    //Run before the game start
    void Start()
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
        Vector3 camera_temp = transform.position;

        if (target.position.x > 2880)
        { camera_temp.x = 2880; }
        else if (target.position.x < 960)
        { camera_temp.x = 960; }

        if (target.position.y > 1620)
        { camera_temp.y = 1620; }
        else if (target.position.y < 540)
        { camera_temp.y = 540; }

        transform.position = camera_temp;
    }
}
