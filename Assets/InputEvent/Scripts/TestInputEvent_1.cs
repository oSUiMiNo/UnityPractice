using UnityEngine;

// InputCallbacks の使い方
public class TestInputEvent_1 : MonoBehaviour
{
    void Start()
    {
        InputCallbacks.OnKeyDown_A += () => Method1();

        InputCallbacks.OnKeyDown_B += () => Method2(3);
        
        InputCallbacks.OnKeyDown_C += () => Debug.Log("ラムダ式も使い捨てとはいえ関数だからね。");
        
        InputCallbacks.OnKeyDown_D += () =>
        {
            Debug.Log("ラムダ式の処理をブロックにすれば、");
            Debug.Log("複数行の処理も登録できるよ。");
        };

        InputCallbacks.OnKeyDown_C += () => Debug.Log("同じイベントでも、いろんなクラスのいろんな場所から処理を追加追加していけるよ。");

        InputCallbacks.OnKeyDown_E += () => Debug.Log("E を押した処理。他のスクリプトからも実装できるか試してみて！");
    }

    void Method1()
    {
        Debug.Log("登録した関数");
        Debug.Log("イベントに関数を「 += 」することで、処理をを登録できるよ。");
    }

    void Method2(int i)
    {
        Debug.Log($"もちろん引数も渡せるよ！ {i}");
    }
}