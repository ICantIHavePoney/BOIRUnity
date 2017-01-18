using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    int dmg;
    GameObject Target;
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
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, bulletSpeed * Time.deltaTime * 0.25f);            
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
