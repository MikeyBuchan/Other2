using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Kin : Enemy_Main 
{
    [Header("Gun")]
    public float fireRate_Per_s;
    public float bulletLifeTime;
    public float bulletSpeed;
    public Transform barrel;
    public GameObject bullet;
    

	void Start () 
	{
        StartCoroutine(PistolShoot());
	}


    void FixedUpdate () 
	{
        MainMovement();
	}

    public IEnumerator PistolShoot()
    {
        GameObject g = Instantiate(bullet, barrel.position, transform.rotation);
        g.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(g, bulletLifeTime);

        yield return new WaitForSeconds(fireRate_Per_s);
        StartCoroutine(PistolShoot());
    }
}
