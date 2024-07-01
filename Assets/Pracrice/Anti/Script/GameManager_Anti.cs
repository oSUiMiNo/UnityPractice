using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Anti : MonoBehaviour
{
    public static int blockCount = 9;
    public static bool gameSet = false;
    public static bool Initialized = false;


    void Start()
    {
        Init();
    }


    public static float timer = 0;
    void Update()
    {
        if ( !gameSet && blockCount == 0)
        {
            timer += Time.deltaTime;
            if(timer >= 0.3)
            {
                Exit();
            }
        }

        if( !Initialized && blockCount == 0 )
        {
            timer += Time.deltaTime;
            if (timer >= 3.5)
            {
                timer = 0;
                Init();
            }
        }
    }


    void Init()
    {
        blockCount = 9;
        gameSet = false;
        Initialized = true;
    }

    void Exit()
    {
        gameSet = true;
        Initialized = false;
    }
}
