using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private float attackTime = 0;
    [SerializeField] private GameObject lightningObject;

    private float timer = 0;
    private float setSpeed = 0;

    public void SetMeleeEnemy(float _attackRange, float _attackTime)
    {
        attackRange = _attackRange;
        attackTime = _attackTime;
    }

    protected override void Start()
    {
        base.Start();
        health = new Health(1,0,1);
        setSpeed = speed;
    }

    protected override void Update()
    {
        base.Update();

        if(!target)
            return;

        if (Vector2.Distance(transform.position, target.position) < attackRange)
        {
            speed = 0;
            Attack(attackTime);
            lightningObject.SetActive(true);
            lightningObject.GetComponent<Animation>().Play();
        }
        else
        {
            speed = setSpeed;
            lightningObject.SetActive(false);
        }
    }

    public override void Attack(float interval)
    {
        if (timer <= interval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            target.GetComponent<iDamageable>().GetDamage(weapon.GetDamage());
        }
    }

    //public override void GetDamage(float damage)
    //{
    //    health.DeductHealth(damage);
    //}
}
