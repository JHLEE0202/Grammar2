using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount = 20;
    public float spawnerRange = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 randomposition = new Vector3(Random.Range(-spawnerRange, spawnerRange), 0f, Random.Range(-spawnerRange, spawnerRange));
            GameObject enemy = Instantiate(enemyPrefab, randomposition, transform.rotation);
            enemy.tag = "enemy";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
