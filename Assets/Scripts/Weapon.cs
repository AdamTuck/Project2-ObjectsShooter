using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private string name;
    private float damage;

    public Weapon (string _name, float _damage)
    {
        name = _name;
        damage = _damage;
    }

    public Weapon ()
    {

    }

    public void Shoot()
    {
        Debug.Log("Shoot weapon");
    }
}
