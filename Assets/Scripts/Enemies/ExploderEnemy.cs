using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploderEnemy : Enemy
{
    public override void Move()
    {

    }

    public override void Shoot(Vector3 direction, float speed)
    {

    }

    public override void Attack(float interval)
    {
        Debug.Log("Machine gun attacking");
    }

    public override void Die()
    {
        Debug.Log("Enemy " + name + ": has died");
    }
}
