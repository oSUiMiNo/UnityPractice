using UnityEngine;




// �e�X�g�p�N���X
public class Test_Event : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------ event �̃e�X�g ------------");

        Process_Event process = new Process_Event();

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
public class Process_Event
{
    // �R�[���o�b�N �̒�`
    public delegate void MyCallback(string result);  // �f���Q�[�g�^ ��錾
    public event MyCallback myCallback;  // �f���Q�[�g�^ �ł��� MyCallback�^ �̃f���Q�[�g�ϐ� �� event�C���q ��t�������� ��錾



    public void Exe()
    {
        Debug.Log("-- �R�[���o�b�N�̃G���g���[�|�C���g --");

        // �R�[���o�b�N���s����
        myCallback?.Invoke("����");
    }
}