using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] private AudioSource SFX;
    [SerializeField] private AudioSource BGM;

    [Header("BGM")]
    [SerializeField] private AudioClip gameMusic;
    [SerializeField] private AudioClip gameMusicStinger;

    [Header("UI SFX")]
    [SerializeField] private AudioClip btnClick;

    [Header("Ambient SFX")]
    [SerializeField] private AudioClip nextLevel;
    [SerializeField] private AudioClip gameOver;

    [Header("Player SFX")]
    [SerializeField] private AudioClip shootGun;

    [Header("Enemy/Powerup SFX")]
    [SerializeField] private AudioClip enemyDeath;
    [SerializeField] private AudioClip enemyExplode;
    [SerializeField] private AudioClip powerupGet;
    [SerializeField] private AudioClip powerupNuke;

    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "btnClick":
                SFX.PlayOneShot(btnClick);
                break;
            case "nextLevel":
                SFX.PlayOneShot(nextLevel);
                break;
            case "gameOver":
                SFX.PlayOneShot(gameOver);
                break;
            case "enemyDeath":
                SFX.PlayOneShot(enemyDeath);
                break;
            case "shootGun":
                SFX.PlayOneShot(shootGun);
                break;
            case "enemyExplode":
                SFX.PlayOneShot(enemyExplode);
                break;
            case "powerupGet":
                SFX.PlayOneShot(powerupGet);
                break;
            case "powerupNuke":
                SFX.PlayOneShot(powerupNuke);
                break;
            case "gameMusic":
                BGM.Stop();
                BGM.loop = true;
                BGM.clip = gameMusic;
                BGM.Play();
                break;
            case "gameMusicStinger":
                BGM.Stop();
                BGM.loop = false;
                BGM.clip = gameMusicStinger;
                BGM.Play();
                break;

                /*case "BallThrow":
                    ballSound.PlayOneShot(ballThrowClip);
                    break;
                case "BallRolling":
                    ballSound.loop = true;
                    ballSound.clip = ballRollingClip;
                    ballSound.Play();
                    break;
                case "collide":
                    ballSound.loop = false;
                    ballSound.Stop();
                    pinSound.PlayOneShot(pinCollisionClip);
                    break;
                case "ballInPit":
                    ballSound.loop = false;
                    ballSound.Stop();
                    ballSound.PlayOneShot(ballInPit);
                    break;
                */
        }

    }
}