using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    LevelLoader levelLoader;
    private static GameManager instance;
    public ScoreManager scoreManager;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPositions;

    [SerializeField] private float enemySpawnRate;

    private GameObject tempEnemy;
    private bool isEnemySpawning;

    private Weapon meleeWeapon = new Weapon("Melee", 1, 0);

    public static GameManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance && instance != this)
        {
            Destroy(this);
        }

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
        scoreManager = FindObjectOfType<ScoreManager>();

        isEnemySpawning = true;
        StartCoroutine(EnemySpawner());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            CreateEnemy();
        }
    }

    void CreateEnemy ()
    {
        tempEnemy = Instantiate(enemyPrefab);
        tempEnemy.transform.position = spawnPositions[Random.Range(0, spawnPositions.Length)].position;

        tempEnemy.GetComponent<Enemy>().weapon = meleeWeapon;
        tempEnemy.GetComponent<MeleeEnemy>().SetMeleeEnemy(2, 0.25f);
    }

    IEnumerator EnemySpawner ()
    {
        while(isEnemySpawning)
        {
            yield return new WaitForSeconds(1.0f/enemySpawnRate);
            CreateEnemy();
        }
    }

    public void StopEnemySpawning()
    {
        isEnemySpawning = false;
    }
}
