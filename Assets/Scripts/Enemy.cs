using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string name;
    private float speed;
    public Health health = new Health();
    public Weapon weapon;

    private EnemyType enemyType;

    public void Move (Transform target)
    {

    }

    public void Shoot(Vector3 direction, float speed)
    {

    }

    public void Attack (float interval)
    {
        Debug.Log("Enemy " + name + ": attacking");
    }
    
    public void Die()
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
