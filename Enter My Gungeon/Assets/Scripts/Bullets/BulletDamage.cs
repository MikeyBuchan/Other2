using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour 
{



    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (c.gameObject.GetComponent<Player_Health>().canTakeDamage == true)
            {
                c.gameObject.GetComponent<Player_Health>().health--;
            }
        }
    }
}
