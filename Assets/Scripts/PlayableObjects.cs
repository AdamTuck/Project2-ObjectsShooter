using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableObjects : MonoBehaviour
{
    public Health health = new Health();
    public Weapon weapon;

    public virtual void Move()
    {
        Debug.Log(name + " base movement");
        Debug.Log("Callnig base move");
    }

    public virtual void Shoot(Vector3 direction, float speed)
    {
        Debug.Log(name + " shooting " + direction + " with speed " + speed);
    }

    public virtual void Attack(float interval)
    {
        Debug.Log(name + ": attacking");
    }

    public virtual void Die()
    {
        Debug.Log(name + ": has died");
    }
}
