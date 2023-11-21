using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:PlayableObjects
{
    private float speed;

    private EnemyType enemyType;

    public override void Move ()
    {

    }

    public override void Shoot(Vector3 direction, float speed)
    {

    }

    public override void Attack (float interval)
    {
        Debug.Log("Enemy " + name + ": attacking");
    }
    
    public override void Die()
    {
        Debug.Log("Enemy " + name + ": has died");
    }

    // EXAMPLE OF BUILT-IN ENUM
    //
    //enum TestEnum {
    //    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    //}

    //private TestEnum testEnum;
}
