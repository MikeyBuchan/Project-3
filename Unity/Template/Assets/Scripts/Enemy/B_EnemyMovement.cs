using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class B_EnemyMovement : MonoBehaviour 
{
    public float health;

    private NavMeshAgent agent;
    public Transform navTarget;
    private Vector3 v = new Vector3(0, 0, 1);

	void Start () 
	{
        agent = gameObject.GetComponent<NavMeshAgent>();
        navTarget = GameObject.FindGameObjectWithTag("EnemyFinish").transform;
	}
	

	void Update () 
	{
        agent.SetDestination(navTarget.position);
        transform.Translate(v * Time.deltaTime);

        if(health <= 0)
        {
            Destroy(gameObject);
            print(gameObject + " died");
        }
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

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Bullet")
        {
            Destroy(c.gameObject);
        }
    }
}
