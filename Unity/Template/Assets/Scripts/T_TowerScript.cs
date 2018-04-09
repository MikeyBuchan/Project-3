using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TowerScript : MonoBehaviour
{
    private R_TowerVars towerVars;

    public Transform closestEnemy;
    public List<Transform> enemies;

    private float timer;

    private void Start()
    {
        towerVars = new R_TowerVars();
    }

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

            timer += Time.deltaTime;
            if(timer >= towerVars.fireRateInSeconds)
            {
                ShootEnemy(towerVars.mainDmg);
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
        closestEnemy.GetComponent<B_EnemyMovement>().health -= damage;
        print("Fired");
    }
}
