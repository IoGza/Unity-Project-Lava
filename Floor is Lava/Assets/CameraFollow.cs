using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.125f;
    //In order to change the x,y, and z axes
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
