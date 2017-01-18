using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {

    GameObject player;
    float X;
    float Y;



    // Use this for initialization
    void Start () {

        player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<EnemyScript>().getAlive() == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 2.5f * Time.deltaTime);
        }
        

    }
}
