using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    float spawningRate;
    public GameObject Fly;

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
        Instantiate(Fly, new Vector3(Random.Range(-6.10f, 6.2f), Random.Range(1.5f, 6.5f), 0), Quaternion.identity);
    }
}

