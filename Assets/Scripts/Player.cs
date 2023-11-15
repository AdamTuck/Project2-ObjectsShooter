using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string nickName;
    private float speed;

    public Health health = new Health();
    public Weapon weapon;

    public void Move (Vector3 direction)
    {
        Debug.Log("Player moves");
    }

    public void Shoot (Vector3 direction, float speed)
    {
        Debug.Log("Player shoots");
    }

    public void Die ()
    {
        Debug.Log("Player dies");
    }
}
