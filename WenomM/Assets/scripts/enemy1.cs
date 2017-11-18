using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy1 : MonoBehaviour {

	public GameObject player;
	public float dist;
	NavMeshAgent nav;
	public float RadiusSee;
	public float RadAttack;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (player.transform.position, transform.position);

		if (dist < RadiusSee) {
			nav.enabled = true;
			nav.SetDestination (player.transform.position);

		} else if (dist > RadiusSee) {
			nav.enabled = false;
		}
	}
}
