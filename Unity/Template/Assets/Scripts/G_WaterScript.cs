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
	public float ability1CDTimer;
	public float timer = 0;
	public float newSpeed;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (Time.time > nextUseTimer) {
		if (Input.GetButtonDown ("Ability 1")){
		agent = gameObject.GetComponent<NavMeshAgent>();
		agent.speed = slowedSpeed;
		nextUseTimer = Time.time + cooldownTimer;
		ability1Timer = ability1CDTimer;
		ability1Timer -= Time.deltaTime;
				}
		}
		if (timer >5){
		agent.speed = newSpeed;
	}
}
	void OnGUI () {
		bool ability1Button = Input.GetButtonDown ("Ability 1");
		if (ability1Timer <= 0 )
		{
			GUI.Label(new Rect( 10, 10, 50, 50), ability1);
					if (ability1Button) {
				AbilityOne () ;
				}
		} else {
			GUI.Label(new Rect( 10, 10, 50, 50), ability1CD);
			}
			if (timer >20) {
				GUI.Label(new Rect( 10, 10, 50, 50), ability1);
				timer =0;
		}
	}
	void AbilityOne () {
			}
	}
