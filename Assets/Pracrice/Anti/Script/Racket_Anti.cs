using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket_Anti : MonoBehaviour
{
    public float speed = 1.0f;
    public float range = 4f;


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (this.transform.position.x > -range)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (this.transform.position.x < range)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}