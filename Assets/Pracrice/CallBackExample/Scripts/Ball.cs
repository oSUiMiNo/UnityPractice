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

        // =============== ボールを動かす ===============
        // 現在の速度を取得
        Vector3 velocity = rb.velocity;
        // (speed ～ speed * 1.5) の範囲内に補正した速度を計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, speed, speed * 1.5f);
        // 速度を反映
        rb.velocity = velocity.normalized * clampedSpeed;
        // ==============================================
    }


    void OnCollisionEnter(Collision collision)
    {
        // ================== 跳ね返り ==================
        if (collision.gameObject.tag == "Racket")
        {
            // プレイヤーの位置を取得
            Vector3 playerPos = collision.transform.position;
            // ボールの位置を取得
            Vector3 ballPos = transform.position;
            // プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballPos - playerPos).normalized;
            // 現在の速さを取得
            float speed = rb.velocity.magnitude;
            // 速度を変更
            rb.velocity = direction * speed;
        }// ==============================================
    }


    private void OnCollisionExit(Collision collision)
    {
        // バウンドの方向が修飾子て永久に真横にバウンドし続けることがあるので、毎バウンド時に少しだけランダムな方向に力をかける
        rb.AddForce(new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)) * 70);
    }
}
