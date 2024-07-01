using System.Collections;
using UnityEngine;

// InputCallbacks の使い方
public class TestInputEvent_2 : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();

        InputCallbacks.OnKeyDown_E += () =>
        {
            Debug.Log("E を押した処理を、他のスクリプトからも実装してみた！");
            Debug.Log("こんな感じでいろんなスクリプトのいろんな行から処理を登録できる！");
        };

        InputCallbacks.OnKeyDown_E += () => StartCoroutine(Method1());
    }



    IEnumerator Method1()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1.5f);

            Debug.Log("こーるばっく ばんざーい！");
        }   
    }
}