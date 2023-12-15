using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukePickup : Pickup
{
    [SerializeField] private float minHealthAdded, maxHealthAdded;

    PowerupManager powerupManager;

    private void Start()
    {
        powerupManager = FindObjectOfType<PowerupManager>();
    }

    public override void OnPicked()
    {
        base.OnPicked();

        powerupManager.GetNuke();
    }
}
