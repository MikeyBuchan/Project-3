﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class B_EnemyMovement : MonoBehaviour 
{
    private NavMeshAgent agent;
    public Transform navTarget;
    private Vector3 v = new Vector3(0, 0, 1);
    public float movSpeed;

	void Start () 
	{
        agent = gameObject.GetComponent<NavMeshAgent>();
        navTarget = GameObject.FindGameObjectWithTag("EnemyFinish").transform;
	}
	

	void Update () 
	{
        agent.SetDestination(navTarget.position);
        transform.Translate(v * movSpeed * Time.deltaTime);
	}

    public void OnTriggerEnter(Collider o)
    {
        if(o.gameObject.tag == "Player")
        {
            navTarget = o.transform;
        }
    }
    public void OnTriggerExit(Collider o)
    {
        navTarget = GameObject.FindGameObjectWithTag("EnemyFinish").transform;
    }
}
