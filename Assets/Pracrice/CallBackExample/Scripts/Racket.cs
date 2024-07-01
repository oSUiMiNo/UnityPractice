using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 1.0f;
    public float range = 4f;


    void Start()
    {
        InputCallbacks.OnKey_A += () =>
        {
            if (this.transform.position.x > -range)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
        };

        InputCallbacks.OnKey_D += () =>
        {
            if (this.transform.position.x < range)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        };
    }
}