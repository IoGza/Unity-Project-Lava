using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlide : MonoBehaviour
{
    Vector3 pos1 = new Vector3(-0.01f,0.003f,0.79f);
    Vector3 pos2 = new Vector3(-0.01f,0.003f,1.2f);
    public float speed = 1f;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        // pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);



    }
}   
