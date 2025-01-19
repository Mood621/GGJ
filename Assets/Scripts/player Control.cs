using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    float xVelocity;
    public float checkRadius;
    public LayerMask platform;

    bool playerDead;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");//GetAxisRaw���Է���-1,0,1������ֵ
        rb.velocity=new Vector2(xVelocity * speed, rb.velocity.y);//xֵ�����ٶȣ�yֵ���ֲ���

        if(xVelocity!=0)//��ֹxVelocity���ֱ��0�����
        transform.localScale = new Vector3(xVelocity, 1, 1);//��Ϸ��ɫ���ݰ����������������ķ�ת
    }
}
