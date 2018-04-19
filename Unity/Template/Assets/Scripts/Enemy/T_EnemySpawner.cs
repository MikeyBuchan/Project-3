using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_EnemySpawner : MonoBehaviour
{
    public bool waveOnGoing;
    public int enemies;

    public GameObject enemy;
    public int waves;
    public float timeBetweenEnemies;

    private int timerEnabled = 0;
    private float time = 0;

    private int enemiesSpawned;
    private int enemiesInWave;

    private void Start()
    {
        StartWave(enemies);
    }

    void Update () 
	{
        time += Time.deltaTime * timerEnabled;

        if(time >= timeBetweenEnemies && enemiesSpawned < enemiesInWave)
        {
            Instantiate(enemy, transform.position, transform.rotation);

            time = 0;
            enemiesSpawned++;
        }
        else if(enemiesSpawned >= enemiesInWave)
        {
            timerEnabled = 0;
            waveOnGoing = false;
        }
	}

    public void StartWave(int i)
    {
        enemiesInWave = i;

        timerEnabled = 1;
        waveOnGoing = true;
    }
}
