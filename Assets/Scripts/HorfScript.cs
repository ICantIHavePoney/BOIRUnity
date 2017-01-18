using UnityEngine;
using System.Collections;

public class HorfScript : MonoBehaviour {

    public GameObject Bullet;
    GameObject Player;
    float x;
    float y;



	// Use this for initialization
	void Start () {

        Player = GameObject.FindWithTag("Player");

        InvokeRepeating("shoot", 5, 5);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void shoot()
    {
        x = Player.transform.position.x - transform.position.x;
        y = Player.transform.position.y - transform.position.y;

        var newBullet = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(x, y, 0) * Time.deltaTime * 100;

        GetComponentInParent<Animator>().SetTrigger("Shoot");

    }


}
