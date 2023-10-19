using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public Transform bulletSpawn;


    public float cooldown;

    private bool canShoot;

    public float range;

    public LayerMask shootMask;

    private GameObject target;

    private void Start()
    {
        Invoke("ResetCooldown", cooldown);
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, range, shootMask);

        if(hit.collider)
        {
            target = hit.collider.gameObject;
            Shooter();
        }
    }

    void ResetCooldown()
    {
        canShoot = true;
    }

    void Shooter()
    {
        if (!canShoot)
            return;
        canShoot = false;
        Invoke("ResetCooldown", cooldown);

        GameObject myBullet = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
    }

}
