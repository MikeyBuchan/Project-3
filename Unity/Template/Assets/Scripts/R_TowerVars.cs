using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_TowerVars : MonoBehaviour {
    public string debugTest;
        
    [Header("Funds")]
    public int cost;
    public int moneyBackPercentage;

    [Header("Damage and health")]
    public float health;
    public float mainDmg;
    public float fireRateInSeconds;
    public float splashRadius;

    [Header("Tower element")]
    public bool isElectric;
    public bool isWater;
    public bool isWind;
    public bool isFire;


   
}
