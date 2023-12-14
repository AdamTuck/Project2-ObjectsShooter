using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    [SerializeField] private float minHealthAdded, maxHealthAdded;

    public override void OnPicked()
    {
        base.OnPicked();

        float healthAdded = Random.Range(minHealthAdded, maxHealthAdded);

        var player = GameManager.GetInstance().GetPlayer();
        player.health.AddHealth(healthAdded);
    }
}
