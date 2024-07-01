using UnityEngine;




// �e�X�g�p�N���X
public class Test_Delegate : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ delegate �̃e�X�g ------------");

        Process_Delegate process = new Process_Delegate();
        
        process.myCallback = A;
        
        process.Exe();
    }




    // �R�[���o�b�N�ɓo�^���鏈�� A
    private void A(string result)
    {
        Debug.Log($"�������sA : {result}");
    }
}






// ���s�p�N���X
public class Process_Delegate
{
    // �R�[���o�b�N �̒�`
    public delegate void MyCallback(string result);  // �f���Q�[�g�^ ��錾
    public MyCallback myCallback;   // �f���Q�[�g�^ �ł��� MyCallback�^ �� �f���Q�[�g�ϐ� ��錾



    public void Exe()
    {
        Debug.Log("-- �R�[���o�b�N�̃G���g���[�|�C���g --");

        // �R�[���o�b�N���s����
        myCallback?.Invoke("����");
    }
}