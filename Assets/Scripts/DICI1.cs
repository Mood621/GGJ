using UnityEngine;
using System.Collections;

public class AutoDisappearAndRespawn : MonoBehaviour
{
    public float riseSpeed = 5.0f; // 上升速度，单位为单位/秒
    public GameObject risingObjectPrefab; // 上升物体的预制体
    public Vector3 respawnPosition; // 重新生成物体的位置

    private Rigidbody2D rb; // 2D刚体组件
    private float timer = 0.0f; // 计时器

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
        // 使物体一直向上移动
        rb.velocity = new Vector2(rb.velocity.x, riseSpeed);

        // 计时器增加
        timer += Time.deltaTime;

        // 如果计时器达到5秒
        if (timer >= 5.0f)
        {
            // 在指定位置重新生成物体
            Instantiate(risingObjectPrefab, respawnPosition, Quaternion.identity);
            // 销毁当前物体
            Destroy(gameObject);
        }
    }
}