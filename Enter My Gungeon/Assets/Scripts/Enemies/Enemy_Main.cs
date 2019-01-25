using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Main : MonoBehaviour 
{
    [Header("Nav Mesh")]
    public NavMeshAgent agent;
    public Transform target;

    [Header("MainOther")]
    public bool playerEnteredRoom = false;
    public float baseSpeed;
    public float health;
    public float stopDistance;

    //This is the main Movement void that makes the enemies move towards the player
    public virtual void MainMovement()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        transform.LookAt(target.position);

        if (playerEnteredRoom == true)
        {
            agent.SetDestination(target.position);
        }

        //gets the distance between own position and Player position, when the enemy comes to close(defined by stopDistance) the enemy stops moving
        if (Vector3.Distance(transform.position, target.position) <= stopDistance)
        {
            agent.speed = 0;
        }
        else
        {
            agent.speed = baseSpeed;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, stopDistance);
    }
}
