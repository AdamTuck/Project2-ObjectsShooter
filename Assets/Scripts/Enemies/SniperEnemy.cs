using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperEnemy : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private float attackTime = 0;

    [SerializeField] private Bullet bulletPrefab;

    [SerializeField] private LineRenderer sightLine;
    [SerializeField] private float sightLineDistanceOffset;

    private float timer = 0;
    private float setSpeed = 0;

    public void SetSniperEnemy(float _attackRange, float _attackTime)
    {
        attackRange = _attackRange;
        attackTime = _attackTime;
    }

    protected override void Start()
    {
        base.Start();
        health = new Health(1, 0, 1);
        setSpeed = speed;
    }

    protected override void Update()
    {
        base.Update();

        if (!target)
            return;

        if (Vector2.Distance(transform.position, target.position) < attackRange)
        {
            speed = 0;
            Attack(attackTime);

            float distancetoTarget = Vector2.Distance(gameObject.transform.position, target.transform.position) * sightLineDistanceOffset;

            SetSights(distancetoTarget);
        }
        else
        {
            speed = setSpeed;
            SetSights(0);
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
            weapon.Shoot(bulletPrefab, this, "Player", 10);
        }
    }

    public void SetSights(float targetX)
    {
        Vector3[] points = new Vector3[2];

        points[0] = new Vector3(0, 0, 1);
        points[1] = new Vector3(targetX, 0, 0);

        sightLine.GetComponent<LineRenderer>().SetPositions(points);
    }
}
