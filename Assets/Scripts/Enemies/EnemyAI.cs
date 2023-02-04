using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    public float pushForce = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        rb.velocity = direction * 10f;

        if (Vector3.Distance(transform.position, player.position) < 2f)
        {
            Vector3 pushDirection = (player.position - transform.position).normalized;
            player.GetComponent<Rigidbody>().AddForce(pushDirection * pushForce,ForceMode.Acceleration);
        }
    }
}
