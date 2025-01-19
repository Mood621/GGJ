using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float distance;
    bool FindEnemy = false;
    GameObject player;
    [SerializeField] private float speed;
    Animator animator;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= distance)
        {
            FindEnemy = true;
        }
        ChasePlayer();
    }

    void ChasePlayer()
    {
        if (FindEnemy)
        {
            animator.SetTrigger("Run");
            if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 3)
            {
                Vector2 dir = (player.transform.position - gameObject.transform.position).normalized;
                transform.Translate(dir * speed * Time.deltaTime);
            }
        }
    }
}
