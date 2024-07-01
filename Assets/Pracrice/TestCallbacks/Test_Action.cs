using UnityEngine;




// �e�X�g�p�N���X
public class Test_Action : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ Action �̃e�X�g ------------");
        
        Process_Action process = new Process_Action();

        process.myCallback += A;
        process.myCallback += B;

        process.Exe();
    }




    // �R�[���o�b�N�ɓo�^���鏈�� A
    private void A(string result)
    {
        Debug.Log($"�������sA : {result}");
    }


    // �R�[���o�b�N�ɓo�^���鏈�� B
    private void B(string result)
    {
        Debug.Log($"�������sB : {result}");
    }
}






// ���s�p�N���X
public class Process_Action
{
    // �R�[���o�b�N �̒�`
    public event System.Action<string> myCallback;  //  �f���Q�[�g�^ �ł��� Action�^ �� �f���Q�[�g�ϐ� ��錾



    public void Exe()
    {
        Debug.Log("-- �R�[���o�b�N�̃G���g���[�|�C���g --");

        // �R�[���o�b�N���s����
        myCallback?.Invoke("����");
    }
}
