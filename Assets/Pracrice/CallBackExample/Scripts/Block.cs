using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void Start()
    {
        GameManager.OnInit += () => Init();
    }

    
    void OnCollisionEnter(Collision collision)
    {
        GameManager.blockCount--;
        gameObject.SetActive(false);
    }


    void Init()
    {
        gameObject.SetActive(true);
    }
}