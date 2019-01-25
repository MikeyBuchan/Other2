using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyOnContact : MonoBehaviour 
{
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
