using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour 
{
    public int health = 6;
    public int healthKeeper = 6;
    public bool canTakeDamage = true;
    public float damageDelay;
    public Text lives;
    public GameObject deathScreen;
	

	void Update () 
	{
        lives.text = "Lives: " + health.ToString();

        HealthCheck();
    }

    public void HealthCheck()
    {
        if (health != healthKeeper)
        {
            StartCoroutine(DamageDelay());
            healthKeeper = health;
        }

        if (health <= 0)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public IEnumerator DamageDelay()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageDelay);
        canTakeDamage = true;
    }
}
