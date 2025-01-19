using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // ÿ���������½��Ĺ̶�λ����������Inspector������
    public float upIncrement = 0.1f;
    public float downIncrement = 0.1f;
    bool isActiveUp = false;
    bool isActiveDown = false;
    Vector3 startPosition;

    // ����ײ����ʱ����
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

    // Start�����ڽű�ʵ��������ʱ����
    void Start()
    {
        startPosition = transform.position;
    }

    // Update������ÿ֡����
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