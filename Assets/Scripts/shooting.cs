using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint01;
    public Transform firePoint02;
    public GameObject bulletPrefab01;
    public GameObject bulletPrefab02;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootFire1();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            ShootFire2();
        }
    }

    void ShootFire1()
    {
        GameObject bullet = Instantiate(bulletPrefab01, firePoint01.position, firePoint01.rotation);
        Rigidbody2D rb  = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint01.up * bulletForce, ForceMode2D.Impulse);
    }

    void ShootFire2()
    {
        GameObject new_bullet = Instantiate(bulletPrefab02, firePoint02.position, firePoint02.rotation);
        Rigidbody2D rb = new_bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint02.up * bulletForce, ForceMode2D.Impulse);
    }
}
