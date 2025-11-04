using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;

    void Update()
    {
        if (player == null) return;

        Vector3 dir = (player.transform.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}


