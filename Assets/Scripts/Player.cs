using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player:PlayableObjects
{
    private string nickName;
    [SerializeField] private float speed;
    [SerializeField] Camera cam;

    [SerializeField] private float weaponDamage = 1;
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private Bullet bulletPrefab;

    public Action<float> OnHealthUpdate;

    Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        health = new Health(100,0.5f,100);

        weapon = new Weapon("Peashooter", weaponDamage, bulletSpeed);

        OnHealthUpdate?.Invoke(health.GetHealth());
    }

    private void Update()
    {
        health.RegenHealth();
    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        playerRB.velocity = direction * speed * Time.deltaTime;

        var playerScreenPos = cam.WorldToScreenPoint(transform.position);
        target.x -= playerScreenPos.x;
        target.y -= playerScreenPos.y;

        float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);
    }

    public override void Shoot()
    {
        Debug.Log("Player shoots a bullet");
        weapon.Shoot(bulletPrefab, this, "Enemy");
    }

    public override void Attack(float interval)
    {
        
    }

    public override void GetDamage(float damage)
    {
        health.DeductHealth(damage);

        OnHealthUpdate?.Invoke(health.GetHealth());

        if (health.GetHealth() <= 0)
        {
            Die();
        }
    }

    public override void Die()
    {
        Debug.Log("Player has died");
        Destroy(gameObject);
    }
}
