using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyOnContact : MonoBehaviour 
{
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
