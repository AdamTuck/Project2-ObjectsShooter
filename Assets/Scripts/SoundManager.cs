using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource eDeathSound, exploderESound, nukeSound;

    [SerializeField] private AudioClip ballThrowClip, ballRollingClip, pinCollisionClip, spareClip, strikeClip, ballInPit;

    public void PlaySound(string soundName)
    {
        // A typical switch...case scenario
        switch (soundName)
        {
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
