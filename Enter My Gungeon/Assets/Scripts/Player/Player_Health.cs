using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour 
{
    public int health = 6;
    public Text lives;
    public GameObject deathScreen;
	

	void Update () 
	{
        lives.text = "Lives: " + health.ToString();

        HealthCheck();
    }

    public void HealthCheck()
    {
        if (health <= 0)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
