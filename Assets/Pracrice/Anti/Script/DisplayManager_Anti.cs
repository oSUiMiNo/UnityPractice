using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager_Anti : MonoBehaviour
{
    GameObject text_GameSet;
    GameObject text_SpaceToStart;


    void Start()
    {
        text_GameSet = GameObject.Find("Text_GameSet");
        text_SpaceToStart = GameObject.Find("Text_SpaceToStart");
        
        Init();
    }


    void Update()
    {
        if (!GameManager_Anti.Initialized && GameManager_Anti.blockCount == 0)
        {
            text_GameSet.SetActive(true);
         
            if ( GameManager_Anti.timer >= 3)
            {
                Init();
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            text_SpaceToStart.SetActive(false);
        }
    }


    void Init()
    {
        text_GameSet.SetActive(false);
        text_SpaceToStart.SetActive(true);
    }
}
