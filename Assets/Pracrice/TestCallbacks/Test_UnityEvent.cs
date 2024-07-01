using UnityEngine;
using UnityEngine.Events;




// �e�X�g�p�N���X
public class Test_UnityEvent : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ UnityEvent �̃e�X�g ------------");
     
        Process_UnityEvent process = new Process_UnityEvent();
        process.myCallback = new UnityEvent<string>();

        process.myCallback.AddListener(A);
        process.myCallback.AddListener(B);

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
public class Process_UnityEvent
{
    // �R�[���o�b�N�̒�`
    public UnityEvent<string> myCallback;  // UnityEvent�^ �̕ϐ� ��錾



    public void Exe()
    {
        Debug.Log("-- �R�[���o�b�N�̃G���g���[�|�C���g --");
     
        // �R�[���o�b�N���s����
        myCallback?.Invoke("����");
    }
}