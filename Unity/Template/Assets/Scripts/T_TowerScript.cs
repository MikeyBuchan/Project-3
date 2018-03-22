using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TowerScript : MonoBehaviour
{
    public Transform closestEnemy;
    public List<Transform> enemies;

    private void OnTriggerEnter(Collider c)
    {      
        if(c.gameObject.tag == "Enemy")
        {
            enemies.Add(c.gameObject.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            enemies.Remove(other.gameObject.transform);
        }
    }

    void Update () 
	{
        if(enemies.Count > 0)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if(closestEnemy == null)
                {
                    closestEnemy = enemies[i];
                }
                else if(Vector3.Distance(transform.position, enemies[i].position) < Vector3.Distance(transform.position,closestEnemy.position))
                {
                    closestEnemy = enemies[i];
                }
            }

            transform.LookAt(closestEnemy);
        }
        else if (enemies.Count == 0)
        {
            closestEnemy = null;
        }
	} 
}
