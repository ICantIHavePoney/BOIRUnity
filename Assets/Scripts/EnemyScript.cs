using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {


    public bool alive;

    int HP;

    Animator m_animator;

	// Use this for initialization
	void Start () {

        alive = true;

        HP = 25;


        m_animator = GetComponent<Animator>();

	}

    // Update is called once per frame
    void Update()
    {



	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Bullet")
        {
            HP -= other.transform.GetComponent<BulletScript>().getDmg();
        }

        if (HP <= 0 && alive)
        {
            alive = false;
            m_animator.SetTrigger("Death");
            Destroy(gameObject, 0.7f);
        }
    }

    public bool getAlive()
    {
        return this.alive;
    }




}
