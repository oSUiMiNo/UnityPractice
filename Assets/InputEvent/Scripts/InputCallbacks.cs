using UnityEngine;

// �L�[�ł������̃C�x���g
public class InputCallbacks : MonoBehaviour
{
    public static event System.Action OnKeyDown_A;
    public static event System.Action OnKeyDown_B;
    public static event System.Action OnKeyDown_C;
    public static event System.Action OnKeyDown_D;
    public static event System.Action OnKeyDown_E;

    public static event System.Action OnKey_A;
    public static event System.Action OnKey_D;
    public static event System.Action OnKeyDown_Space;

    void Update()
    {
        // ���� if�� ���ȉ��̗l�ɏȗ����Ă���
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnKeyDown_A?.Invoke();
        }

        // ��������s�̏ꍇ�̓u���b�N���ȗ��ł���
        if (Input.GetKeyDown(KeyCode.B))
            OnKeyDown_B?.Invoke();
        
        // �S���P�s�ɂ����`
        if (Input.GetKeyDown(KeyCode.C)) OnKeyDown_C?.Invoke();
        if (Input.GetKeyDown(KeyCode.D)) OnKeyDown_D?.Invoke();
        if (Input.GetKeyDown(KeyCode.E)) OnKeyDown_E?.Invoke();

        if (Input.GetKey(KeyCode.A)) OnKey_A?.Invoke();
        if (Input.GetKey(KeyCode.D)) OnKey_D?.Invoke();
        if (Input.GetKey(KeyCode.Space)) OnKeyDown_Space?.Invoke();
    }
}
