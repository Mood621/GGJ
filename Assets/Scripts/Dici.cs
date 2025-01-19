using UnityEngine;

public class CustomContinuousFalling : MonoBehaviour
{
    public float fallSpeed = 5.0f; // 下坠速度，单位为单位/秒
    public GameObject fallingObjectPrefab; // 下坠物体的预制体
    public Vector2 newSpawnPosition; // 新生成物体的位置

    private Rigidbody2D rb; // 2D刚体组件

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D组件未添加到物体上！");
        }
    }

    void Update()
    {
        // 使物体一直向下移动
        rb.velocity = new Vector2(rb.velocity.x, -fallSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 当物体碰撞到其他物体时消失，并在指定位置生成新的物体
        Instantiate(fallingObjectPrefab, newSpawnPosition, Quaternion.identity);
        Destroy(gameObject);
    }
}