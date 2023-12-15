using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private string name;
    private float damage;
    private float bulletSpeed;

    public Weapon (string _name, float _damage, float _bulletSpeed)
    {
        name = _name;
        damage = _damage;
        bulletSpeed = _bulletSpeed;
    }

    public Weapon ()
    {

    }

    public void Shoot(Bullet _bullet, PlayableObjects _player, string _targetTag, float _timeToDie = 5)
    {
        Bullet bullet = GameObject.Instantiate(_bullet, _player.transform.position, _player.transform.rotation);
        bullet.SetBullet(damage, _targetTag, bulletSpeed);

        GameObject.Destroy(bullet.gameObject, _timeToDie);
    }

    public float GetDamage ()
    {
        return damage;
    }
}