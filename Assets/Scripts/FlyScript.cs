using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {

    GameObject player;
    float X;
    float Y;

    bool alive;

    int HP;

    Animator m_animator;

	// Use this for initialization
	void Start () {

        alive = true;

        HP = 25;

        player = GameObject.FindWithTag("Player");

        m_animator = GetComponent<Animator>();

	}

    // Update is called once per frame
    void Update()
    {

        if (alive)
        { 
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 2.5f * Time.deltaTime);
        }
 

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Bullet")
        {
            HP -= other.transform.GetComponent<BulletScript>().getDmg();
        }

        if (HP <= 0)
        {
            alive = false;
            m_animator.SetTrigger("Death");
            Destroy(gameObject, 0.2f);
        }
    }




}
