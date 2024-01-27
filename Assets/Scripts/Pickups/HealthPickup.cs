using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    PowerupManager powerupManager;
    [SerializeField] private float minHealthAdded, maxHealthAdded;
    private void Start()
    {
        powerupManager = FindObjectOfType<PowerupManager>();
    }

    public override void OnPicked()
    {
        base.OnPicked();

        float healthAdded = Random.Range(minHealthAdded, maxHealthAdded);

        var player = GameManager.GetInstance().GetPlayer();
        player.health.AddHealth(healthAdded);

        powerupManager.GiveHealth();
    }
}
