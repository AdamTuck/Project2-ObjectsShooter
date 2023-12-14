using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy:PlayableObjects
{
    GameManager gameManager;

    //private float name;
    [SerializeField] protected float speed;
    [SerializeField] private GameObject deathExplosion;
    protected Transform target;

    private EnemyType enemyType;

    protected virtual void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        try
        {
            target = GameObject.FindWithTag("Player").transform;
        }
        catch (NullReferenceException e)
        {
            gameManager.StopEnemySpawning();
            Debug.Log(e);
        }   
    }

    protected virtual void Update()
    {
        if (target) // might need: if (target != null)
        {
            Move(target.position);
        } 
        else
        {
            Move(speed);
        }
    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        
    }

    /// <summary>
    /// Using the move method moves the enemy automatically without having a target.
    /// </summary>
    /// <param name="speed"></param>
    public override void Move (float speed)
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    /// <summary>
    /// Moving the enemy with a target will have it constantly move towards the player (at its default speed).
    /// </summary>
    /// <param name="direction"></param>
    public override void Move(Vector2 direction)
    {
        direction.x -= transform.position.x;
        direction.y -= transform.position.y;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public override void Shoot()
    {
        
    }

    public override void GetDamage(float damage)
    {
        health.DeductHealth(damage);

        GameManager.GetInstance().scoreManager.IncrementScore(1);
        if (health.GetHealth() <= 0)
        {
            Die();
        }
    }

    public override void Attack(float interval)
    {
        
    }

    public override void Die()
    {
        gameManager.NotifyDeath(this);
        DeathExplosion();
        Destroy(gameObject);
    }

    private void DeathExplosion()
    {
        GameObject deathExplosionInstance = Instantiate(deathExplosion, this.transform.position, Quaternion.identity);
        Destroy(deathExplosionInstance, 5);
    }

    // EXAMPLE OF BUILT-IN ENUM
    //
    //enum TestEnum {
    //    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    //}

    //private TestEnum testEnum;
}
