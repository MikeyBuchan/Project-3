using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TowerScript : MonoBehaviour
{
    public Transform closestEnemy;
    public List<Transform> enemies;

    private float timer;

    private bool checkList;

    private void OnTriggerEnter(Collider c)
    {      
        if(c.gameObject.tag == "Enemy")
        {
            enemies.Add(c.gameObject.transform);
            checkList = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            enemies.Remove(other.gameObject.transform);
            checkList = true;
        }
    }

    void Update () 
	{
        if(enemies.Count > 0)
        {
            if(checkList == true)
            {
                for (int i = 0; i < enemies.Count; i++)
                {
                    if(enemies[i] == null)
                    {
                        enemies.RemoveAt(i);
                        i--;
                    }

                    if (closestEnemy == null)
                    {
                        closestEnemy = enemies[i];
                    }
                    else if (Vector3.Distance(transform.position, enemies[i].position) < Vector3.Distance(transform.position, closestEnemy.position))
                    {
                        closestEnemy = enemies[i];
                    }
                }
                checkList = false;
            }

            transform.LookAt(closestEnemy);

            timer += Time.deltaTime;
            if(timer >= GetComponentInParent<R_TowerVars>().fireRateInSeconds)
            {
                ShootEnemy(GetComponentInParent<R_TowerVars>().mainDmg);
                timer = 0;
            }
        }
        else if (enemies.Count == 0)
        {
            closestEnemy = null;
        }
	} 

    void ShootEnemy(float damage)
    {
        if(closestEnemy != null)
        {
            closestEnemy.GetComponent<B_EnemyMovement>().health -= damage;
            print("Fired, did " + damage + " damage");
        }     
    }
}
