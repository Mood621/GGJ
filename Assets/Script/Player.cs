using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    public float speed;
    Rigidbody2D rb;
    public float jumpHeight; // 公开的跳跃高度，可在游戏里调试

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        // 检测跳跃输入
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void Movement()
    {
        // 只处理水平移动
        float xVelocity = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, 0);
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        // 根据 xVelocity 的正负设置缩放
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(xVelocity), 1, 1);
        }
    }

    void Jump()
    {
        // 直接设置角色的 Y 轴位置，实现跳跃高度的位移
        Vector2 newPosition = rb.position + Vector2.up * jumpHeight;
        rb.MovePosition(newPosition);
    }
}