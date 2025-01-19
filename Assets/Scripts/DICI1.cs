using UnityEngine;
using System.Collections;

public class AutoDisappearAndRespawn : MonoBehaviour
{
    public float riseSpeed = 5.0f; // �����ٶȣ���λΪ��λ/��
    public GameObject risingObjectPrefab; // ���������Ԥ����
    public Vector3 respawnPosition; // �������������λ��

    private Rigidbody2D rb; // 2D�������
    private float timer = 0.0f; // ��ʱ��

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D���δ��ӵ������ϣ�");
        }
    }

    void Update()
    {
        // ʹ����һֱ�����ƶ�
        rb.velocity = new Vector2(rb.velocity.x, riseSpeed);

        // ��ʱ������
        timer += Time.deltaTime;

        // �����ʱ���ﵽ5��
        if (timer >= 5.0f)
        {
            // ��ָ��λ��������������
            Instantiate(risingObjectPrefab, respawnPosition, Quaternion.identity);
            // ���ٵ�ǰ����
            Destroy(gameObject);
        }
    }
}