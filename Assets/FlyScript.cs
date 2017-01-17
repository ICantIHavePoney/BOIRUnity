using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {

    GameObject player;
    float X;
    float Y;

    int HP;

	// Use this for initialization
	void Start () {

        player = GameObject.FindWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {



        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 2.5f * Time.deltaTime);

	}


}
