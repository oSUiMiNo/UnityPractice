using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed = 15;
    bool isMoving = false;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        GameManager.OnInit += () => transform.position = new Vector3(0, 1.4f, -6.5f);
        GameManager.OnInit += () => isMoving = false;
        GameManager.OnBlocksLost += () => rb.velocity = Vector3.zero;
        
        InputCallbacks.OnKeyDown_Space += () =>
        {
            if (isMoving) return;
            if (GameManager.gameSet && !GameManager.Initialized) return;
            rb.velocity = new Vector3(speed, 0, speed);
            isMoving = true;
        };
    }


    void Update()
    {
        if (GameManager.gameSet) return;

        // =============== �{�[���𓮂��� ===============
        // ���݂̑��x���擾
        Vector3 velocity = rb.velocity;
        // (speed �` speed * 1.5) �͈͓̔��ɕ␳�������x���v�Z
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, speed, speed * 1.5f);
        // ���x�𔽉f
        rb.velocity = velocity.normalized * clampedSpeed;
        // ==============================================
    }


    void OnCollisionEnter(Collision collision)
    {
        // ================== ���˕Ԃ� ==================
        if (collision.gameObject.tag == "Racket")
        {
            // �v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;
            // �{�[���̈ʒu���擾
            Vector3 ballPos = transform.position;
            // �v���C���[���猩���{�[���̕������v�Z
            Vector3 direction = (ballPos - playerPos).normalized;
            // ���݂̑������擾
            float speed = rb.velocity.magnitude;
            // ���x��ύX
            rb.velocity = direction * speed;
        }// ==============================================
    }


    private void OnCollisionExit(Collision collision)
    {
        // �o�E���h�̕������C���q�ĉi�v�ɐ^���Ƀo�E���h�������邱�Ƃ�����̂ŁA���o�E���h���ɏ������������_���ȕ����ɗ͂�������
        rb.AddForce(new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)) * 70);
    }
}
