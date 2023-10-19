using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suns : MonoBehaviour
{
    private float dropToYPos;

    private float speed = 0.15f;


    private void Start()
    {
        transform.position = new Vector3(Random.Range(-4f, 8.35f),0.0f);
        dropToYPos = Random.Range(2f, -3f);
        Destroy(gameObject, Random.Range(6f,12f));
    }
    private void Update()
    {
        if (transform.position.y >= dropToYPos)
        {
            transform.position -= new Vector3(0, speed * Time.fixedDeltaTime, 0);
        }

    }
}
