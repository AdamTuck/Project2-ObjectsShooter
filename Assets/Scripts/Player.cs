using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:PlayableObjects
{
    private string nickName;
    private float speed;

    private void Start()
    {
        Move();
    }

    public override void Move ()
    {
        base.Move();
        Debug.Log("local player movement");
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log("Player shoots");
    }

    public override void Die()
    {
        base.Die();
    }
}
