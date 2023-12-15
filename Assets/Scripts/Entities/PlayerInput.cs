using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PowerupManager powerupManager;
    private Player player;
    private float horizontal, vertical;
    private Vector2 lookTarget;

    public bool gunActive;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        powerupManager = FindObjectOfType<PowerupManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.GetInstance().IsPlaying())
            return;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        lookTarget = Input.mousePosition;

        if (powerupManager.IsGunActive() && Input.GetMouseButton(0))
        {
            player.Shoot();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            powerupManager.NukeScreen();
        }
        else if (Input.GetMouseButtonDown(0))
        {
            player.Shoot();
        }
    }

    private void FixedUpdate()
    {
        player.Move(new Vector2(horizontal, vertical), lookTarget);
    }
}
