using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy_Main 
{
    [Header("Slime")]
    public int contactDamage;

	void Start () 
	{
		
	}
	

	void FixedUpdate () 
	{
        MainMovement();
	}

    void OnCollisionEnter(Collision c)
    {
        if(Vector3.Distance(transform.position, target.position) <= stopDistance)
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.GetComponent<Player_Health>().health -= contactDamage;
        }
    }
}
