using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class G_WaterScript : MonoBehaviour {
	public float slowedSpeed;
	private NavMeshAgent agent;
	public float cooldownTimer;
	public float nextUseTimer;
	public Texture2D ability1;
	public Texture2D ability1CD;
	float ability1Timer = 0;
	public float ability1CDtimer;

	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent>();
		ability1Timer -= Time.deltaTime;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextUseTimer) {
		if (Input.GetButtonDown ("Ability 1")){
		agent.speed = slowedSpeed;
		nextUseTimer = Time.time + cooldownTimer;
		}
		}
	}
	void OnGUI () {
		bool ability1Button = Input.GetButtonDown ("Ability 1");
		if (ability1Timer <= 0 )
		{
			GUI.Label(new Rect( 10, 10, 50, 50, ability1));
					if (ability1Button) {
				AbilityOne () ;
				}
		} else {
			GUI.Label(new Rect( 10, 10, 50, 50, ability1));
			}
		}
	void AbilityOne () {
	}
}
