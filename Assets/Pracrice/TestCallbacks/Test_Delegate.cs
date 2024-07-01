using UnityEngine;




// テスト用クラス
public class Test_Delegate : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ delegate のテスト ------------");

        Process_Delegate process = new Process_Delegate();
        
        process.myCallback = A;
        
        process.Exe();
    }




    // コールバックに登録する処理 A
    private void A(string result)
    {
        Debug.Log($"処理実行A : {result}");
    }
}






// 実行用クラス
public class Process_Delegate
{
    // コールバック の定義
    public delegate void MyCallback(string result);  // デリゲート型 を宣言
    public MyCallback myCallback;   // デリゲート型 である MyCallback型 の デリゲート変数 を宣言



    public void Exe()
    {
        Debug.Log("-- コールバックのエントリーポイント --");

        // コールバック実行命令
        myCallback?.Invoke("成功");
    }
}