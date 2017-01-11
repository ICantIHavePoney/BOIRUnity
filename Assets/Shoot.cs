using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    float VertDirection;
    float LatDirection;

    public GameObject bullet;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left"))
        {
            LatDirection = -0.1f;
            VertDirection = 0;
        }
        else if (Input.GetKeyDown("up"))
        {
            VertDirection = 0.1f;
            LatDirection = 0;
        }
        else if (Input.GetKeyDown("right"))
        {
            LatDirection = 0.1f;
            VertDirection = 0;
        }
        else if (Input.GetKeyDown("down"))
        {
            VertDirection = -0.1f;
            LatDirection = 0;
        }
        else
        {
            VertDirection = 0;
            LatDirection = 0;
        }

        shoot();
	}

    void shoot()
    {

        if(VertDirection != 0 || LatDirection != 0)
        {
            Debug.Log("toto");
            GameObject newBullet = Instantiate(bullet, new Vector3(transform.position.x + LatDirection, transform.position.y + VertDirection, 0), Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = new Vector3(LatDirection * 100, VertDirection * 100, 0);
            //bullet.GetComponent<Bullet>().Constructor(this.GetComponentInParent<Movement>().getRange());
            Destroy(newBullet, GetComponentInParent<Movement>().getRange());

        }
    }
}
