using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 0.8f;
    float height = 1.78f;
    Vector3 startPos;
    public int dir = 1;
    Vector3 pos;
    void Start()
    {
        // startPos = this.transform.position;
        pos = transform.position;
        // this.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        if(transform.position.y < 1.78)
            dir = -1;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);


    }
}
