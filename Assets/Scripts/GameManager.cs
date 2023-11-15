using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player mainPlayer = new Player();

        Enemy meleeEnemy = new Enemy();
        Enemy shooterEnemy = new Enemy();

        Weapon peashooter = new Weapon("Peashooter", 1);
        Weapon machineGun = new Weapon("Machine Gun", 1);
        Weapon meleeWeapon = new Weapon();

        mainPlayer.weapon = peashooter;
        shooterEnemy.weapon = machineGun;
        meleeEnemy.weapon = meleeWeapon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
