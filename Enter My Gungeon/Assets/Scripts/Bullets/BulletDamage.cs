using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamage : MonoBehaviour 
{

	void Start () 
	{
		
	}
	

	void Update () 
	{
		
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.GetComponent<Player_Health>().health--;
        }
    }
}
