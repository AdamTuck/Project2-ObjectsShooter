using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    UIManager uiManager;

    //[Header("Gun Powerup")]
    [SerializeField] private float gunPowerupLength;
    private float gunTimer;
    private bool gunActive;

    private float gunTimerBarSize;

    //[Header("Nuke Powerup")]
    private int nukesAcquired;
    [SerializeField] GameObject explosionObject;
    [SerializeField] private float explosionSize;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        TimeOutGun();
    }

    public void ActivateGun()
    {
        gunTimer = gunPowerupLength;
        gunActive = true;
    }

    private void TimeOutGun()
    {
        if (gunActive)
        {
            gunTimer -= Time.deltaTime;

            gunTimerBarSize = gunTimer / gunPowerupLength;

            GameManager.GetInstance().GetPlayer().SetGunTimer(gunTimerBarSize);

            if (gunTimer <= 0)
            {
                gunActive = false;
                GameManager.GetInstance().GetPlayer().SetGunTimer(0);
            }
        }
    }

    public bool IsGunActive()
    {
        return gunActive;
    }

    public void GetNuke()
    {
        nukesAcquired++;
        uiManager.UpdateNukeText(nukesAcquired);
    }

    public int NukesAcquired()
    {
        return nukesAcquired;
    }

    public void NukeScreen()
    {
        if (nukesAcquired > 0) 
        { 
            nukesAcquired--;
            uiManager.UpdateNukeText(nukesAcquired);

            GameObject nukeExplosionInstance = Instantiate(explosionObject, GameManager.GetInstance().GetPlayer().transform.position, Quaternion.identity);

            nukeExplosionInstance.transform.localScale = new Vector3
                (nukeExplosionInstance.transform.localScale.x * explosionSize, nukeExplosionInstance.transform.localScale.y * explosionSize, nukeExplosionInstance.transform.localScale.z * explosionSize);

            Destroy(nukeExplosionInstance, 5);

            GameManager.GetInstance().WipeScreen();
        }
    }

    public void ResetPowerups()
    {
        nukesAcquired = 0;
        gunActive = false;
    }
}
