using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    int dmg;
    public GameObject Target;
    int bulletSpeed;

    bool homing;

    // Use this for initialization
    void Start () {

        homing = true;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Target != null && Target.GetComponent<EnemyScript>().getAlive())
        {
            var velo = GetComponent<Rigidbody2D>().velocity;
            velo.Set(Target.transform.position.x - transform.position.x, Target.transform.position.y - transform.position.y);
            velo.Normalize();
            GetComponent<Rigidbody2D>().velocity = velo * Time.deltaTime * bulletSpeed;
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        
        Destroy(gameObject);
    }

    public int getDmg()
    {
        return this.dmg;
    }

    public void setDmg(int d)
    {
        this.dmg = d;
    }

    public void setBulletSpeed(int sP)
    {
        this.bulletSpeed = sP;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Enemy" && homing) Target = other.gameObject;
    }
}
