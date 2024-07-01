using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int blockCount = 9;
    public static bool gameSet = false;
    public static bool Initialized = false;

    public static event System.Action OnBlocksLost;
    public static event System.Action OnInit;


    void Start()
    {
        Init();

        OnInit += () => Init();
        OnBlocksLost += () => Exit();
    }


    float timer = 0;
    void Update()
    {
        if (!gameSet && blockCount == 0) OnBlocksLost?.Invoke();  // �R�[���o�b�N���s

        if (!Initialized && blockCount == 0)
        {
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                timer = 0;
                OnInit?.Invoke();  // �R�[���o�b�N���s  
            }
        }
    }


    void Init()  // �Q�[����Ԃ̏�����
    {
        blockCount = 9;
        gameSet = false;
        Initialized = true;
    }


    void Exit()  // �Q�[���̌㏈��
    {
        gameSet = true;
        Initialized = false;
    }
}