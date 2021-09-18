
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{

    private bool movingRight;
    private bool movingLeft;
    public float speed = 0.05f;
    Vector3 pos1 = new Vector3 (-0.241f,3.077f,3.981f);
    Vector3 pos2 = new Vector3 (0.858f,3.08f,4.016f);
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

                    
                    
                
            
            // else if(transform.position.x <= 0.4591681)
            // {
            //     Vector3 movement = new Vector3(Mathf.Sin(movementSpeed * Time.time) * -1, transform.position.y,transform.position.z);
            //     transform.position = movement;
            // }
        }
        
   
        

    }
}
