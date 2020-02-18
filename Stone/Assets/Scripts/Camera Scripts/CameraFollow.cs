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
        Vector3 camera_postion = transform.position;
        camera_postion = target.position;
        //transform.position = camera_postion;

    }
}
