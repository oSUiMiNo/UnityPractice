using UnityEngine;




// テスト用クラス
public class Test_Event : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ event のテスト ------------");

        Process_Event process = new Process_Event();

        process.myCallback += A;
        process.myCallback += B;

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
public class Process_Event
{
    // コールバック の定義
    public delegate void MyCallback(string result);  // デリゲート型 を宣言
    public event MyCallback myCallback;  // デリゲート型 である MyCallback型 のデリゲート変数 に event修飾子 を付けたもの を宣言



    public void Exe()
    {
        Debug.Log("-- コールバックのエントリーポイント --");

        // コールバック実行命令
        myCallback?.Invoke("成功");
    }
}