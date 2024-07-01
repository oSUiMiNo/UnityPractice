using UnityEngine;
using UnityEngine.Events;




// テスト用クラス
public class Test_UnityEvent : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ UnityEvent のテスト ------------");
     
        Process_UnityEvent process = new Process_UnityEvent();
        process.myCallback = new UnityEvent<string>();

        process.myCallback.AddListener(A);
        process.myCallback.AddListener(B);

        process.Exe();
    }




    // コールバックに登録する処理 A
    private void A(string result)
    {
        Debug.Log($"処理実行A : {result}");
    }


    // コールバックに登録する処理 B
    private void B(string result)
    {
        Debug.Log($"処理実行B : {result}");
    }
}







// 実行用クラス
public class Process_UnityEvent
{
    // コールバックの定義
    public UnityEvent<string> myCallback;  // UnityEvent型 の変数 を宣言



    public void Exe()
    {
        Debug.Log("-- コールバックのエントリーポイント --");
     
        // コールバック実行命令
        myCallback?.Invoke("成功");
    }
}