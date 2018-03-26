using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_TowerVars : MonoBehaviour {
    [Header("Funds")]
    public int cost;
    public int moneyBackAfterDestroy;

    [Header("Normal damage")]
    public float dmg;
    
    [Header("Splash damage")]
    public bool doesSplashDmg;
    public float splashRadius;
    public Vector2 minMaxDmg;

   
}
