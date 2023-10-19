using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;

    public float health;

    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0);
    }
    public void Hit(int damge)
    {
        health -= damge;
        if (health <= 0)
            Destroy(gameObject);
    }
}
