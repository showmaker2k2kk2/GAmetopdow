using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu_ban : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


        bullet bulletComponent = bullet.GetComponent<bullet>();
        if (bulletComponent != null)
        {

            bulletComponent.speed = 20f;
        }
    }
}
