using UnityEngine;

public class CustomContinuousFalling : MonoBehaviour
{
    public float fallSpeed = 5.0f; // ��׹�ٶȣ���λΪ��λ/��
    public GameObject fallingObjectPrefab; // ��׹�����Ԥ����
    public Vector2 newSpawnPosition; // �����������λ��

    private Rigidbody2D rb; // 2D�������

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
        rb.velocity = new Vector2(rb.velocity.x, -fallSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ��������ײ����������ʱ��ʧ������ָ��λ�������µ�����
        Instantiate(fallingObjectPrefab, newSpawnPosition, Quaternion.identity);
        Destroy(gameObject);
    }
}