using System.Collections;
using UnityEngine;

// InputCallbacks �̎g����
public class TestInputEvent_2 : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();

        InputCallbacks.OnKeyDown_E += () =>
        {
            Debug.Log("E ���������������A���̃X�N���v�g������������Ă݂��I");
            Debug.Log("����Ȋ����ł����ȃX�N���v�g�̂����ȍs���珈����o�^�ł���I");
        };

        InputCallbacks.OnKeyDown_E += () => StartCoroutine(Method1());
    }



    IEnumerator Method1()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1.5f);

            Debug.Log("���[��΂��� �΂񂴁[���I");
        }   
    }
}