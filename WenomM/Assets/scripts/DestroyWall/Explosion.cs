using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public float radius, force;
	
	// Update is called once per frame
	void Update () {
		Collider[] hitColliders = Physics.OverlapSphere (transform.position, radius);
		for (int i = 0; i < hitColliders.Length; i++) {
			if (hitColliders [i].GetComponent<CanBeDestroyed> ()) {
				hitColliders [i].GetComponent < CanBeDestroyed> ().Dead ();
			}
			if (hitColliders [i].CompareTag ("CanBeRigidbody")) {
				hitColliders [i].gameObject.AddComponent<Rigidbody> ();
			}
		}
	}
	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, radius);
	}
}
