﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour 
{
    [Header("GunInfo")]
    public Transform barrel;
    public GameObject currentGun;
    public GameObject bullet;
    public float bulletSpeed;
    public float fireRate_Per_s;
    public float bulletLifeTime;

	void Start () 
	{
		
	}
	

	void Update () 
	{
        Shoot();
	}

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject g = Instantiate(bullet, barrel.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            Destroy(g, bulletLifeTime);
        }
    }
}
