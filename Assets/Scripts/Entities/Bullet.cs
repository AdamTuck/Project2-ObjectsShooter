using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;

    private string targetTag;

    public void SetBullet(float _damage, string _targetTag, float _speed = 10)
    {
        this.damage = _damage;
        this.targetTag = _targetTag;
        this.speed = _speed;
    }

    private void Update()
    {
        Move();
    }

    void Move ()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void Damage (iDamageable damageable)
    {
        if (damageable != null)
        {
            damageable.GetDamage(damage);
            //Debug.Log("Dealing " + damage + " damage");

            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag(targetTag))
            return;

        //Debug.Log("Bullet hit " + collision.gameObject.name);

        iDamageable damageable = collision.GetComponent<iDamageable>();
        Damage(damageable);
    }
}