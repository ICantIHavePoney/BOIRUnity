using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    int hp;
    float speed;
    int fireRate;
    int bulletSpeed;
    float range;
    int damages;

    float translateVert;
    float translateLat;

    Animator m_animator;


	// Use this for initialization
	void Start () {



        hp = 100;
        speed = 0.15f;
        range = 0.5f;

        m_animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        translateLat = Input.GetAxis("Horizontal") * speed;
        translateVert = Input.GetAxis("Vertical") * speed;



        transform.Translate(translateLat, translateVert, 0);

        m_animator.SetFloat("VertDirection", translateVert);
        m_animator.SetFloat("LatDirection", translateLat);
            
	}

    public float getRange()
    {
        return this.range;
    }
}
