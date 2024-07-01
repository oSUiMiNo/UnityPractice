using UnityEngine;




// テスト用クラス
public class Test_Action : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ Action のテスト ------------");
        
        Process_Action process = new Process_Action();

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
public class Process_Action
{
    // コールバック の定義
    public event System.Action<string> myCallback;  //  デリゲート型 である Action型 の デリゲート変数 を宣言



    public void Exe()
    {
        Debug.Log("-- コールバックのエントリーポイント --");

        // コールバック実行命令
        myCallback?.Invoke("成功");
    }
}
