using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        
        float movementX = Input.GetAxis("Horizontal") * 1 * Time.deltaTime;
        gameObject.transform.Translate(-movementX, 0, 0);

        if (Input.GetKey("w")) {
            speed += 1;
        }
        if (Input.GetKey("s")) {
            speed -= 1;
        }
        if (Input.GetKeyDown("space")){
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -speed);
        }

        look

        Console.Write(speed);
    }
}
