using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    UIManager uiManager;
    SoundManager soundManager;

    //[Header("Gun Powerup")]
    [SerializeField] private float gunPowerupLength;
    [SerializeField] private float gunBulletDelay;
    private float gunBulletTimer, gunTimer;
    private bool gunActive, gunBulletReady;

    private float gunTimerBarSize;

    //[Header("Nuke Powerup")]
    private int nukesAcquired;
    [SerializeField] GameObject explosionObject;
    [SerializeField] private float explosionSize;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        soundManager = GameManager.GetInstance().soundManager;
    }

    private void Update()
    {
        TimeOutGun();
    }

    public void ActivateGun()
    {
        gunTimer = gunPowerupLength;
        gunActive = true;
        soundManager.PlaySound("powerupGet");
    }

    private void TimeOutGun()
    {
        if (gunActive)
        {
            gunTimer -= Time.deltaTime;
            gunBulletTimer += Time.deltaTime;

            gunTimerBarSize = gunTimer / gunPowerupLength;

            GameManager.GetInstance().GetPlayer().SetGunTimer(gunTimerBarSize);

            if (gunTimer <= 0)
            {
                gunActive = false;
                GameManager.GetInstance().GetPlayer().SetGunTimer(0);
            }

            if (gunBulletTimer >= gunBulletDelay)
            {
                gunBulletTimer = 0;
                gunBulletReady = true;
            }
        }
    }

    public bool IsGunActive()
    {
        bool willGunShoot = false;

        if (gunActive && gunBulletReady)
        {
            gunBulletReady = false;
            willGunShoot = true;
        }

        return willGunShoot;
    }

    public void GiveHealth() 
    {
        soundManager.PlaySound("powerupGet");
    }

    public void GetNuke()
    {
        nukesAcquired++;
        uiManager.UpdateNukeText(nukesAcquired);
        soundManager.PlaySound("powerupGet");
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

            soundManager.PlaySound("powerupNuke");

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
