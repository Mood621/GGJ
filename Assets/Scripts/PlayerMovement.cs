using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float moveSpeed = 5.0f;

    private Rigidbody2D rb1;  // 玩家1的Rigidbody组件
    private Rigidbody2D rb2;  // 玩家2的Rigidbody组件
    //private bool isGrounded1 = true;  // 玩家1是否在地面上
    //private bool isGrounded2 = true;  // 玩家2是否在地面上
    
    void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();

    }

   private void Move()
    {
        float moveX1 = Input.GetAxis("Horizontal_1");
        float moveZ1 = Input.GetAxis("Vertical_1");
        Vector3 moveDirection1 = new Vector3(moveX1, 0, moveZ1).normalized;
        player1.position += moveDirection1 * moveSpeed * Time.deltaTime;

        // 玩家2的移动控制
        float moveX2 = Input.GetAxis("Horizontal_2");
        float moveZ2 = Input.GetAxis("Vertical_2");
        Vector3 moveDirection2 = new Vector3(moveX2, 0, moveZ2).normalized;
        player2.position += moveDirection2 * moveSpeed * Time.deltaTime;

    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        // 检测玩家是否落地，以允许再次跳跃
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (player1.CompareTag("Player1"))
            {
                isGrounded1 = false;
            }
            if (player2.CompareTag("Player2"))
            {
                isGrounded2 = false;
            }
        }
    }*/

}