using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Blob : Enemy_Main 
{
    [Header("Gun")]
    public float fireRate_Per_s;
    public float bulletSpeed;
    public Transform barrel;
    public GameObject bullet;
    public int bulletAmount;

    void Start () 
	{
        StartCoroutine(RoundShoot());
	}
	

	void FixedUpdate () 
	{
        MainMovement();
	}

    public IEnumerator RoundShoot()
    {
        for (int i = 0; i < bulletAmount; i++)
        {
            GameObject g = Instantiate(bullet, barrel.position, Quaternion.identity);
            g.transform.Rotate(Vector3.up * (360f / bulletAmount * i));
            g.GetComponent<Rigidbody>().AddForce(g.transform.forward * bulletSpeed);
        }

        yield return new WaitForSeconds(1f / fireRate_Per_s);
        StartCoroutine(RoundShoot());
    }
}
