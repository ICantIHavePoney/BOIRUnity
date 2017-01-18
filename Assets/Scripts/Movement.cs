using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {



    float translateVert;
    float translateLat;

    Animator m_animator;

    float speed;

	// Use this for initialization
	void Start () {

        speed = GetComponentInParent<Stats>().getSpeed();

        m_animator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {

        translateLat = Input.GetAxis("Horizontal") * speed;
        translateVert = Input.GetAxis("Vertical") * speed;



        transform.Translate(translateLat  * Time.deltaTime, translateVert * Time.deltaTime, 0);

        m_animator.SetFloat("VertDirection", translateVert);
        m_animator.SetFloat("LatDirection", translateLat);

	}


}
