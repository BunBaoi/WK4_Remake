using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{


    public Transform[] spawnpoints; // Create a list


    public GameObject zombie; // Prefab of the zombie

    private void Start()
    {
        InvokeRepeating("SpawnZombie", 2, 5); // Spawn every 2 to 5 seconds
    }


    void SpawnZombie()
    {
        int r = Random.Range(0, spawnpoints.Length); // Spawn between the length of inputed transform "spawnpoints" location
        GameObject myZombie = Instantiate(zombie, spawnpoints[r].position, Quaternion.identity);
        Debug.Log("Spawn");
    }
}
