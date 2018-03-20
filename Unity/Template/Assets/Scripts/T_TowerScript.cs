using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TowerScript : MonoBehaviour
{
    public GameObject closestEnemy;
    public GameObject secondEnemy;

    private int enemiesInRange;

    private void OnTriggerEnter(Collider c)
    {      
        if(c.gameObject.tag == "Enemy" && closestEnemy == null)
        {
            closestEnemy = c.gameObject;
            enemiesInRange++;
        }
        else if(c.gameObject.tag == "Enemy" && closestEnemy != null)
        {
            secondEnemy = c.gameObject;
            enemiesInRange++;
        }

        if (secondEnemy != null && closestEnemy != null && Vector3.Distance(transform.position, secondEnemy.transform.position) > Vector3.Distance(transform.position, closestEnemy.transform.position))
        {
            closestEnemy = secondEnemy;
            secondEnemy = null;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            enemiesInRange--;
        }
    }

    void Update () 
	{
        if(enemiesInRange >= 1)
        {
            transform.LookAt(closestEnemy.transform);
        }
	} 
}
