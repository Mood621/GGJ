using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // 每次上升或下降的固定位移量，可在Inspector面板调整
    public float upIncrement = 0.1f;
    public float downIncrement = 0.1f;
    bool isActiveUp = false;
    bool isActiveDown = false;
    Vector3 startPosition;

    // 当碰撞发生时调用
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isActiveUp = true;
            isActiveDown = false;
        }
        else
        {
            isActiveUp = false;
            isActiveDown = true;
        }
    }

    // Start方法在脚本实例被启用时调用
    void Start()
    {
        startPosition = transform.position;
    }

    // Update方法在每帧调用
    void Update()
    {
        if (isActiveUp)
        {
            Vector3 newPosition = transform.position;
            newPosition.y += upIncrement;
            transform.position = newPosition;
        }
        if (isActiveDown && transform.position != startPosition)
        {
            Vector3 newPosition = transform.position;
            newPosition.y -= downIncrement;
            transform.position = newPosition;
        }
    }
}