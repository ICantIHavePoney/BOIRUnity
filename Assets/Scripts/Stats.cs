using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

     int hp;
     float speed;
     float fireRate;
     int bulletSpeed;
     float range;
     int damages;
    bool homing;
    bool diagonale;

    // Use this for initialization
    void Start () {
	
	}
	
    void Awake()
    {
        hp = 100;
        speed = 5;
        range = 1;
        fireRate = 0.5f;
        damages = 30;
        bulletSpeed = 500;
        diagonale = true;
    }

    // Update is called once per frame
    void Update () {
	
	}

    public float getSpeed()
    {
        return this.speed;
    }

    public float getRange()
    {
        return this.range;
    }

    public float getFireRate()
    {
        return this.fireRate;
    }

    public int getDamages()
    {
        return this.damages;
    }

    public int getBulletSpeed()
    {
        return this.bulletSpeed;
    }

    public int getHP()
    {
        return this.hp;
    }

    public bool getHoming()
    {
        return this.homing;
    }
    public bool getDiagonale()
    {
        return this.diagonale;
    }


    public void setHP(int HP)
    {
        this.hp = HP;
    }
}
