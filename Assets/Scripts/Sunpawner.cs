using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunpawner : MonoBehaviour
{
    public GameObject sunObject;

    private void Start()
    {
        SpawnSun();
    }

    void SpawnSun()
    {
        Instantiate(sunObject);
        Invoke("SpawnSun", Random.Range(2, 8));
    }
}
