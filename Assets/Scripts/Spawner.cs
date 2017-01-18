using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    float spawningRate;
    public GameObject Fly;
    public GameObject Horf;

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("spawn", 5, 5);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawn()
    {
        int rand = Random.Range(1, 3);

        if(rand == 1) Instantiate(Fly, new Vector3(Random.Range(-6.10f, 6.2f), Random.Range(1.5f, 6.5f), 0), Quaternion.identity);

        else if(rand == 2) Instantiate(Horf, new Vector3(Random.Range(-6.10f, 6.2f), Random.Range(1.5f, 6.5f), -1), Quaternion.identity);
    }
}

