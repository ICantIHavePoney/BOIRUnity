using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    float VertDirection;
    float LatDirection;

    public GameObject bullet;
    public GameObject body;

    bool isShooting;

    float nextFire;

    Stats stats;

    Animator m_animator;

	// Use this for initialization
	void Start () {
        m_animator = GetComponent<Animator>();
        isShooting = false;
        stats = GetComponentInParent<Stats>();
    }

	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(body.transform.position.x, body.transform.position.y + 0.55f, body.transform.position.z - 0.01f);



        if (Input.GetKey("left"))
        {
            isShooting = true;
            LatDirection = -1f;
            VertDirection = 0;
            shoot();
        }
        else if (Input.GetKey("up"))
        {
            isShooting = true;
            VertDirection = 1f;
            LatDirection = 0;
                    shoot();
        }
        else if (Input.GetKey("right"))
        {
            isShooting = true;
            LatDirection = 1f;
            VertDirection = 0;
                    shoot();
        }
        else if (Input.GetKey("down"))
        {
            isShooting = true;
            VertDirection = -1f;
            LatDirection = 0;
            shoot();
        }
        else
        {
            isShooting = false;
            LatDirection = Input.GetAxis("Horizontal");
            VertDirection = Input.GetAxis("Vertical");
        }

        m_animator.SetBool("isShooting", isShooting);
        m_animator.SetFloat("LatDirection", LatDirection);
        m_animator.SetFloat("VertDirection", VertDirection);



	}

    void shoot()
    {

        if(Time.time > nextFire){

            nextFire = Time.time + stats.getFireRate();
            GameObject newBullet = Instantiate(bullet, new Vector3(transform.position.x + LatDirection, transform.position.y + VertDirection, 0), Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(LatDirection, VertDirection, 0) * Time.deltaTime * stats.getBulletSpeed();
            newBullet.GetComponent<BulletScript>().setDmg(stats.getDamages());
            newBullet.GetComponent<BulletScript>().setBulletSpeed(stats.getBulletSpeed());
            Destroy(newBullet, stats.getRange());

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Enemy")
        {

            stats.setHP(stats.getHP() - 15);
        }
    }
}
