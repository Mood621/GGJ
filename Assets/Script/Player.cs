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
    public float jumpHeight; // ��������Ծ�߶ȣ�������Ϸ�����

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

        // �����Ծ����
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void Movement()
    {
        // ֻ����ˮƽ�ƶ�
        float xVelocity = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, 0);
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        // ���� xVelocity ��������������
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(xVelocity), 1, 1);
        }
    }

    void Jump()
    {
        // ֱ�����ý�ɫ�� Y ��λ�ã�ʵ����Ծ�߶ȵ�λ��
        Vector2 newPosition = rb.position + Vector2.up * jumpHeight;
        rb.MovePosition(newPosition);
    }
}