
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSideTwo : MonoBehaviour
{

    private bool movingRight;
    private bool movingLeft;
    public float speed = 0.05f;
    Vector3 pos1 = new Vector3 (-0.132f,2.639f,5.844f);
    Vector3 pos2 = new Vector3 (-0.651f,2.641f,5.873f);
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        // startPos = this.transform.position;
        movingRight = true;
        // movingLeft = true;
        // pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingRight)
        {
            // transform.position = Vector3.Lerp(pos1,pos2,Mathf.PingPong(Time.time*speed,1.0f));
            transform.localPosition = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
        }
        
   
        

    }
}
