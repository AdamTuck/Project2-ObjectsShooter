using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Enemy testEnemy = new Enemy();

    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy(testEnemy);
    }

    public void SpawnEnemy (Enemy enemyToSpawn)
    {
        Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
    }

    public void SpawnEnemy (string enemyName)
    {
        GameObject newEnemy = Resources.Load<GameObject>(enemyName);
        Instantiate(newEnemy, transform.position, Quaternion.identity);
    }
}
