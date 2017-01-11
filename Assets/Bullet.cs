using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    float range;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, range);
    }

    void awaka()
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Constructor(float r)
    {
        this.range = r;
    }
}
