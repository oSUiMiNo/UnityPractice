using UnityEngine;

// InputCallbacks �̎g����
public class TestInputEvent_1 : MonoBehaviour
{
    void Start()
    {
        InputCallbacks.OnKeyDown_A += () => Method1();

        InputCallbacks.OnKeyDown_B += () => Method2(3);
        
        InputCallbacks.OnKeyDown_C += () => Debug.Log("�����_�����g���̂ĂƂ͂����֐�������ˁB");
        
        InputCallbacks.OnKeyDown_D += () =>
        {
            Debug.Log("�����_���̏������u���b�N�ɂ���΁A");
            Debug.Log("�����s�̏������o�^�ł����B");
        };

        InputCallbacks.OnKeyDown_C += () => Debug.Log("�����C�x���g�ł��A�����ȃN���X�̂����ȏꏊ���珈����ǉ��ǉ����Ă������B");

        InputCallbacks.OnKeyDown_E += () => Debug.Log("E �������������B���̃X�N���v�g����������ł��邩�����Ă݂āI");
    }

    void Method1()
    {
        Debug.Log("�o�^�����֐�");
        Debug.Log("�C�x���g�Ɋ֐����u += �v���邱�ƂŁA��������o�^�ł����B");
    }

    void Method2(int i)
    {
        Debug.Log($"�������������n�����I {i}");
    }
}