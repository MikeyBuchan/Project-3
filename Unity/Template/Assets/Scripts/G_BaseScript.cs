using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_BaseScript : MonoBehaviour {
	public int towerHealth =500;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (towerHealth <=0){
			Destroy(gameObject);
		}
		
	}
}
