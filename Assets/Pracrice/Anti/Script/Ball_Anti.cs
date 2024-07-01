using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball_Anti : MonoBehaviour
{
    float speed = 15;
    bool isMoving = false;
    Rigidbody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isMoving)
            {
                if (!GameManager_Anti.gameSet && GameManager_Anti.Initialized)
                {
                    rb.velocity = new Vector3(speed, 0, speed);
                    isMoving = true;
                }
            }
        }
        
        if (!GameManager_Anti.Initialized && GameManager_Anti.blockCount == 0)
        {
            rb.velocity = Vector3.zero;
            
            if (GameManager_Anti.timer >= 3)
            {
                Init();
            }
        }

        if (GameManager_Anti.gameSet) return;

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
        rb.AddForce(new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)) * 70);
    }


    void Init()
    {
        transform.position = new Vector3(0, 1.4f, -6.5f);
        isMoving = false;
    }
}