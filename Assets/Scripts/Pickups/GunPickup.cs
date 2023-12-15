using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : Pickup
{
    [SerializeField] private float gunPowerupLength;

    PowerupManager powerupManager;

    private void Start()
    {
        powerupManager = FindObjectOfType<PowerupManager>();
    }

    public override void OnPicked()
    {
        base.OnPicked();

        powerupManager.ActivateGun();
    }
}
