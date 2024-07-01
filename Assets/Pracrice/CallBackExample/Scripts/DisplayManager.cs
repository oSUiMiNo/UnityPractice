using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    GameObject text_GameSet;
    GameObject text_SpaceToStart;


    void Start()
    {
        text_GameSet = GameObject.Find("Text_GameSet");
        text_SpaceToStart = GameObject.Find("Text_SpaceToStart");
     
        Init();

        InputCallbacks.OnKeyDown_Space += () => text_SpaceToStart.SetActive(false);
        GameManager.OnBlocksLost += () => text_GameSet.SetActive(true);
        GameManager.OnInit += () => Init();
    }


    void Init()
    {
        text_GameSet.SetActive(false);
        text_SpaceToStart.SetActive(true);
    }
}
