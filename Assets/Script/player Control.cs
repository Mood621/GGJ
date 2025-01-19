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
        xVelocity = Input.GetAxisRaw("Horizontal");//GetAxisRaw可以返回-1,0,1这三种值
        rb.velocity=new Vector2(xVelocity * speed, rb.velocity.y);//x值乘以速度，y值保持不变

        if(xVelocity!=0)//防止xVelocity出现变成0的情况
        transform.localScale = new Vector3(xVelocity, 1, 1);//游戏角色根据按键方向来决定它的翻转
    }
}
