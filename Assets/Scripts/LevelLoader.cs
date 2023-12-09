using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player mainPlayer = new Player();

        //Enemy meleeEnemy = new Enemy();
        //Enemy shooterEnemy = new Enemy();

        Weapon peashooter = new Weapon("Peashooter", 1, 10);
        Weapon machineGun = new Weapon("Machine Gun", 1, 10);
        Weapon meleeWeapon = new Weapon();

        mainPlayer.weapon = peashooter;
        //shooterEnemy.weapon = machineGun;
        //meleeEnemy.weapon = meleeWeapon;


        //SquidCreature squid1 = new SquidCreature();
        //SquidCreature squid2 = new SquidCreature();

        //squid1.Colour("Blue");
        //squid2.Colour("Red");

        //squid1.Legs(8);
        //squid2.Legs(6);

        //squid1.Eyes(2);
        //squid2.Eyes(2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel1()
    {

    }
}
