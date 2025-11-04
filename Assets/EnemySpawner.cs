using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject player;   //  Player를 받아올 변수
    public int enemyCount = 20;
    public float spawnerRange = 50.0f;

    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawnerRange, spawnerRange), 0f, Random.Range(-spawnerRange, spawnerRange));
            GameObject enemy = Instantiate(enemyPrefab, randomPosition, transform.rotation);
            enemy.tag = "enemy";

            //  생성된 Enemy에게 Player 전달
            enemy.GetComponent<EnemyMove>().player = player;
        }
    }
}

