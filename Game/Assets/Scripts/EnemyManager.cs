using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public Transform[] spawnPoint;
    public GameObject[] EnemyTypes;
    public List<GameObject> enemies;
    public int health;
    public Animator anim;
    public void EnemyKilled(GameObject _enemy)
    {
        enemies.Remove(_enemy);
        print(enemies.Count);
    }

    void Start()
    {
        for (int i = 0; i < 101; i++)
        {
            print(i);
        }
        SpawnEnemy();
        anim = GetComponent<Animator>();
        

    }
    void SpawnEnemy()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            int rndEnemy = Random.Range(0, EnemyTypes.Length);

            GameObject enemy = Instantiate(EnemyTypes[rndEnemy], spawnPoint[i].position, spawnPoint[i].rotation);
            enemies.Add(enemy);
        }
        print("Enemy Count: " + enemies.Count);
    }

}
