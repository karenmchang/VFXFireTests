using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform cam;

    void Start()
    {
        //Find the gameobject named "Main Camera" and get it's transform. Set it to the variable cam.
        cam = GameObject.Find("Main Camera").transform;
    }

    void Update()
    {
        Vector3 direction = cam.position - transform.position;
        direction.y = 0f; //this line makes sure that the plane won't tilt up or down.
        transform.rotation = Quaternion.LookRotation(direction);

    }
}
